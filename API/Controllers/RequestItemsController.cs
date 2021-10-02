using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using API.ActionFilters;
using API.Utility;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
    [Route("api/RequestItems/{RequestHeaderId}/RequestItems")]
    [ApiController]
    public class RequestItemsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public RequestItemsController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet, Authorize]
        public async Task<IActionResult> GetRequestItemsForRequestHeader(Guid RequestHeaderId, [FromQuery] RequestItemParameters RequestItemParameters)
        {
            /*if (!RequestItemParameters.ValidAgeRange)
                return BadRequest("Max age can't be less than min age.");*/

            var RequestHeader = await _repository.RequestHeader.GetRequestHeaderAsync(RequestHeaderId, trackChanges: false);
            if (RequestHeader == null)
            {
                _logger.LogInfo($"RequestHeader with id: {RequestHeaderId} doesn't exist in the database.");
                return NotFound();
            }

            var RequestItemsFromDb = await _repository.RequestItem.GetRequestItemsAsync(RequestHeaderId, RequestItemParameters, trackChanges: false);

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(RequestItemsFromDb.MetaData));

            var RequestItemsDto = _mapper.Map<IEnumerable<RequestItemDto>>(RequestItemsFromDb);

            return Ok(RequestItemsDto);
        }

        [HttpGet("{id}", Name = "GetRequestItemForRequestHeader"), Authorize]
        public async Task<IActionResult> GetRequestItemForRequestHeader(Guid RequestHeaderId, Guid id)
        {
            var RequestHeader = await _repository.RequestHeader.GetRequestHeaderAsync(RequestHeaderId, trackChanges: false);
            if (RequestHeader == null)
            {
                _logger.LogInfo($"RequestHeader with id: {RequestHeaderId} doesn't exist in the database.");
                return NotFound();
            }

            var RequestItemDb = await _repository.RequestItem.GetRequestItemAsync(RequestHeaderId, id, trackChanges: false);
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
        public async Task<IActionResult> CreateRequestItemForRequestHeader(Guid RequestHeaderId, [FromBody] RequestItemForCreationDto RequestItem)
        {
            var RequestHeader = await _repository.RequestHeader.GetRequestHeaderAsync(RequestHeaderId, trackChanges: false);
            if(RequestHeader == null)
            {
                _logger.LogInfo($"RequestHeader with id: {RequestHeaderId} doesn't exist in the database.");
                return NotFound();
            }

            var RequestItemEntity = _mapper.Map<RequestItem>(RequestItem);
            
            _repository.RequestItem.CreateRequestItemForRequestHeader(RequestHeaderId, RequestItemEntity);
            await _repository.SaveAsync();

            var RequestItemToReturn = _mapper.Map<RequestItemDto>(RequestItemEntity);

            return CreatedAtRoute("GetRequestItemForRequestHeader", new { RequestHeaderId, id = RequestItemToReturn.Id }, RequestItemToReturn);
        }

        [HttpDelete("{id}"), Authorize]
        [ServiceFilter(typeof(ValidateItemForRequestExistsAttribute))]
        public async Task<IActionResult> DeleteRequestItemForRequestHeader(Guid RequestHeaderId, Guid id)
        {
            var RequestItemForRequestHeader = HttpContext.Items["requestItem"] as RequestItem;

            _repository.RequestItem.DeleteRequestItem(RequestItemForRequestHeader);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("{id}"), Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateItemForRequestExistsAttribute))]
        public async Task<IActionResult> UpdateRequestItemForRequestHeader(Guid RequestHeaderId, Guid id, [FromBody] RequestItemForUpdateDto RequestItem)
        {
            var RequestItemEntity = HttpContext.Items["requestItem"] as RequestItem;

            _mapper.Map(RequestItem, RequestItemEntity);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPatch("{id}"), Authorize]
        [ServiceFilter(typeof(ValidateItemForRequestExistsAttribute))]
        public async Task<IActionResult> PartiallyUpdateRequestItemForRequestHeader(Guid RequestHeaderId, Guid id, [FromBody] JsonPatchDocument<RequestItemForUpdateDto> patchDoc)
        {
            if(patchDoc == null)
            {
                _logger.LogError("patchDoc object sent from client is null.");
                return BadRequest("patchDoc object is null");
            }

            var RequestItemEntity = HttpContext.Items["requestItem"] as RequestItem;

            var RequestItemToPatch = _mapper.Map<RequestItemForUpdateDto>(RequestItemEntity);

            patchDoc.ApplyTo(RequestItemToPatch, ModelState);

            TryValidateModel(RequestItemToPatch);

            if(!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the patch document");
                return UnprocessableEntity(ModelState);
            }

            _mapper.Map(RequestItemToPatch, RequestItemEntity);

            await _repository.SaveAsync();

            return NoContent();
        }
    }
}