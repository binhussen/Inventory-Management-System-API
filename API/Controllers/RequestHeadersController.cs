using AutoMapper;
using API.ActionFilters;
using API.ModelBinders;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/requestheaders")]
    [ApiController]
    public class RequestHeadersController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public RequestHeadersController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetRequestHeaders"), Authorize]
        public async Task<IActionResult> GetRequestHeaders()
        {
            var requestHeaders = await _repository.RequestHeader.GetAllRequestHeadersAsync(trackChanges:false);

            var requestHeaderDtos = _mapper.Map<IEnumerable<RequestHeaderDto>>(requestHeaders);

            return Ok(requestHeaderDtos);
        }

        [HttpGet("{id}", Name = "RequestHeaderById"), Authorize]
        public async Task<IActionResult> GetRequestHeader(Guid id)
        {
            var requestheader = await _repository.RequestHeader.GetRequestHeaderAsync(id, trackChanges: false);
            if (requestheader == null)
            {
                _logger.LogInfo($"RequestHeader with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            else
            {
                var requestHeaderDto = _mapper.Map<RequestHeaderDto>(requestheader);
                return Ok(requestHeaderDto);
            }
        }

        [HttpGet("collection/({ids})", Name = "RequestHeaderCollection"), Authorize]
        public async Task<IActionResult> GetRequestHeaderCollection([ModelBinder(BinderType = typeof(ArrayModelBinder))]IEnumerable<Guid> ids)
        {
            if(ids == null)
            {
                _logger.LogError("Parameter ids is null");
                return BadRequest("Parameter ids is null");
            }

            var requestHeaderEntities = await _repository.RequestHeader.GetByIdsAsync(ids, trackChanges: false);

            if(ids.Count() != requestHeaderEntities.Count())
            {
                _logger.LogError("Some ids are not valid in a collection");
                return NotFound();
            }

            var companiesToReturn = _mapper.Map<IEnumerable<RequestHeaderDto>>(requestHeaderEntities);
            return Ok(companiesToReturn);
        }

        /// <summary>
        /// Creates a newly created RequestHeader
        /// </summary>
        /// <param name="RequestHeader"></param>
        /// <returns>A newly created RequestHeader</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>
        /// <response code="422">If the model is invalid</response>
        [HttpPost(Name = "CreateRequestHeader"), Authorize]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(422)]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateRequestHeader([FromBody]RequestHeaderForCreationDto requestHeader)
        {
            var requestHeaderEntity = _mapper.Map<RequestHeader>(requestHeader);

            _repository.RequestHeader.CreateRequestHeader(requestHeaderEntity);
            await _repository.SaveAsync();

            var requestHeaderToReturn = _mapper.Map<RequestHeaderDto>(requestHeaderEntity);

            return CreatedAtRoute("RequestHeaderById", new { id = requestHeaderToReturn.Id }, requestHeaderToReturn);
        }
        [HttpPost("collection"), Authorize]
        public async Task<IActionResult> CreateRequestHeaderCollection([FromBody] IEnumerable<RequestHeaderForCreationDto> requestHeaderCollection)
        {
            if(requestHeaderCollection == null)
            {
                _logger.LogError("RequestHeader collection sent from client is null.");
                return BadRequest("RequestHeader collection is null");
            }

            var requestHeaderEntities = _mapper.Map<IEnumerable<RequestHeader>>(requestHeaderCollection);
            foreach (var requestHeader in requestHeaderEntities)
            {
                _repository.RequestHeader.CreateRequestHeader(requestHeader);
            }

            await _repository.SaveAsync();

            var requestHeaderCollectionToReturn = _mapper.Map<IEnumerable<RequestHeaderDto>>(requestHeaderEntities);
            var ids = string.Join(",", requestHeaderCollectionToReturn.Select(c => c.Id));

            return CreatedAtRoute("RequestHeaderCollection", new { ids }, requestHeaderCollectionToReturn);
        }

        [HttpDelete("{id}"), Authorize]
        [ServiceFilter(typeof(ValidateRequestExistsAttribute))]
        public async Task<IActionResult> DeleteRequestHeader(Guid id)
        {
            var requestHeader = HttpContext.Items["requestHeader"] as RequestHeader;

            _repository.RequestHeader.DeleteRequestHeader(requestHeader);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("{id}"), Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateRequestExistsAttribute))]
        public async Task<IActionResult> UpdateRequestHeader(Guid id, [FromBody] RequestHeaderForUpdateDto requestHeader)
        {
            var requestHeaderEntity = HttpContext.Items["requestHeader"] as RequestHeader;

            _mapper.Map(requestHeader, requestHeaderEntity);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpOptions, Authorize]
        public IActionResult GetCompaniesOptions()
        {
            Response.Headers.Add("Allow", "GET, OPTIONS, POST");

            return Ok();
        }
    }
}