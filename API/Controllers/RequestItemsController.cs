using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using API.ActionFilters;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace API.Controllers
{
    [Route("api/requestitems/{requestheaderid}/requestitems")]
    [ApiController]
    public class RequestItemsController : ControllerBase
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public RequestItemsController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        [HttpGet, Authorize]
        public async Task<IActionResult> GetRequestItemsForRequestHeader(Guid requestheaderid, [FromQuery] RequestItemParameters requestItemParameters)
        {
            var RequestHeader = await _repository.RequestHeader.GetRequestHeaderAsync(requestheaderid, trackChanges: false);
            if (RequestHeader == null)
            {
                _logger.LogInfo($"RequestHeader with id: {requestheaderid} doesn't exist in the database.");
                return NotFound();
            }

            var RequestItemsFromDb = await _repository.RequestItem.GetRequestItemsAsync(requestheaderid, requestItemParameters, trackChanges: false);

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(RequestItemsFromDb.MetaData));

            var RequestItemsDto = _mapper.Map<IEnumerable<RequestItemDto>>(RequestItemsFromDb);

            return Ok(RequestItemsDto);
        }

        [HttpGet("{id}", Name = "GetRequestItemForRequestHeader"), Authorize]
        public async Task<IActionResult> GetRequestItemForRequestHeader(Guid requestheaderid, Guid id)
        {
            var RequestHeader = await _repository.RequestHeader.GetRequestHeaderAsync(requestheaderid, trackChanges: false);
            if (RequestHeader == null)
            {
                _logger.LogInfo($"RequestHeader with id: {requestheaderid} doesn't exist in the database.");
                return NotFound();
            }

            var RequestItemDb = await _repository.RequestItem.GetRequestItemAsync(requestheaderid, id, trackChanges: false);
            if (RequestItemDb == null)
            {
                _logger.LogInfo($"RequestItem with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            var RequestItem = _mapper.Map<RequestItemDto>(RequestItemDb);

            return Ok(RequestItem);
        }

        [HttpPost, Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateRequestItemForRequestHeader(Guid requestheaderid, [FromBody] RequestItemForCreationDto RequestItem)
        {
            var RequestHeader = await _repository.RequestHeader.GetRequestHeaderAsync(requestheaderid, trackChanges: false);
            if(RequestHeader == null)
            {
                _logger.LogInfo($"RequestHeader with id: {requestheaderid} doesn't exist in the database.");
                return NotFound();
            }

            var RequestItemEntity = _mapper.Map<RequestItem>(RequestItem);
            
            _repository.RequestItem.CreateRequestItemForRequestHeader(requestheaderid, RequestItemEntity);
            RequestItemEntity.TotalPrice = RequestItemEntity.UnitPrice * RequestItemEntity.Quantity;
            await _repository.SaveAsync();

            var RequestItemToReturn = _mapper.Map<RequestItemDto>(RequestItemEntity);

            return CreatedAtRoute("GetRequestItemForRequestHeader", new { requestheaderid, id = RequestItemToReturn.Id }, RequestItemToReturn);
        }

        [HttpDelete("{id}"), Authorize]
        [ServiceFilter(typeof(ValidateItemForRequestExistsAttribute))]
        public async Task<IActionResult> DeleteRequestItemForRequestHeader(Guid requestheaderid, Guid id)
        {
            var RequestItemForRequestHeader = HttpContext.Items["requestItem"] as RequestItem;

            _repository.RequestItem.DeleteRequestItem(RequestItemForRequestHeader);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("{id}"), Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateItemForRequestExistsAttribute))]
        public async Task<IActionResult> UpdateRequestItemForRequestHeader(Guid requestheaderid, Guid id, [FromBody] RequestItemForUpdateDto RequestItem)
        {
            var RequestItemEntity = HttpContext.Items["requestItem"] as RequestItem;
            _mapper.Map(RequestItem, RequestItemEntity);
            RequestItemEntity.TotalPrice = RequestItemEntity.UnitPrice * RequestItemEntity.Quantity;
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("distribute/{id}"), Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateItemForRequestExistsAttribute))]
        public async Task<IActionResult> Distribute(Guid requestheaderid, Guid id, [FromBody] RequestItemForDistributeDto RequestItem)
        {
            var RequestItemEntity = HttpContext.Items["requestItem"] as RequestItem;
            var currentTime = DateTimeOffset.UtcNow;
            _mapper.Map(RequestItem, RequestItemEntity);
            RequestItemEntity.Status = 5;
            RequestItemEntity.DistributeBy = _httpContextAccessor.HttpContext.User.Identity.Name;
            RequestItemEntity.DistributeDate = currentTime;
            /*update store*/
            var storesFromDb = await _repository.Store.EditStoreItemAsync(RequestItem.StoreItemId, trackChanges: true);
            if (storesFromDb.QtyRemain != 0)
            {
                storesFromDb.QtyRemain = storesFromDb.QtyRemain - RequestItemEntity.ApprovedQuantity;
            }
            else
            {
                storesFromDb.QtyRemain = storesFromDb.QtyReceived - RequestItemEntity.ApprovedQuantity;
            }
            if (storesFromDb.QtyRemain == 0)
                storesFromDb.Status = 1;
            /**/
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("approve/{id}"), Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateItemForRequestExistsAttribute))]
        public async Task<IActionResult> Approve(Guid requestheaderid, Guid id, [FromBody] RequestItemForApprovementDto RequestItem)
        {
            var RequestItemEntity = HttpContext.Items["requestItem"] as RequestItem;
            var currentTime = DateTimeOffset.UtcNow;
            _mapper.Map(RequestItem, RequestItemEntity);
            RequestItemEntity.Status = 1;
            RequestItemEntity.ApprovedBy = _httpContextAccessor.HttpContext.User.Identity.Name;
            RequestItemEntity.ApprovedDate = currentTime;
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("reject/{id}"), Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateItemForRequestExistsAttribute))]
        public async Task<IActionResult> Reject(Guid requestheaderid, Guid id, [FromBody] BodyDto empity)
        {
            var RequestItemEntity = HttpContext.Items["requestItem"] as RequestItem;
            var currentTime = DateTimeOffset.UtcNow;
            RequestItemEntity.ApprovedQuantity = 0;
            RequestItemEntity.Status = 2;
            RequestItemEntity.ApprovedBy = _httpContextAccessor.HttpContext.User.Identity.Name;
            RequestItemEntity.ApprovedDate = currentTime;
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("buy/{id}"), Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateItemForRequestExistsAttribute))]
        public async Task<IActionResult> Buy(Guid requestheaderid, Guid id, [FromBody] BodyDto empity)
        {
            var RequestItemEntity = HttpContext.Items["requestItem"] as RequestItem;
            var currentTime = DateTimeOffset.UtcNow;
            RequestItemEntity.Status = 3;
            RequestItemEntity.BuyBy = _httpContextAccessor.HttpContext.User.Identity.Name;
            RequestItemEntity.BuyDate = currentTime;
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("notbuy/{id}"), Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateItemForRequestExistsAttribute))]
        public async Task<IActionResult> NotBuy(Guid requestheaderid, Guid id, [FromBody] BodyDto empity)
        {
            var RequestItemEntity = HttpContext.Items["requestItem"] as RequestItem;
            var currentTime = DateTimeOffset.UtcNow;
            RequestItemEntity.Status = 4;
            RequestItemEntity.BuyBy = _httpContextAccessor.HttpContext.User.Identity.Name;
            RequestItemEntity.BuyDate = currentTime;
            await _repository.SaveAsync();

            return NoContent();
        }
    }
}