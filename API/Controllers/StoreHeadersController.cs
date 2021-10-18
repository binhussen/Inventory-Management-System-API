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
using Entities.RequestFeatures;
using Newtonsoft.Json;

namespace API.Controllers
{
    [Route("api/storeheaders")]
    [ApiController]
    public class StoreHeadersController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public StoreHeadersController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetStoreHeaders"), Authorize]
        public async Task<IActionResult> GetStoreHeaders([FromQuery] StoreItemParameters storeParameters)
        {
            var storeHeaders = await _repository.StoreHeader.GetStoresAsync(storeParameters,trackChanges:false);

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(storeHeaders.MetaData));

            var storeHeaderDtos = _mapper.Map<IEnumerable<StoreHeaderDto>>(storeHeaders);

            return Ok(storeHeaderDtos);
        }

        [HttpGet("{id}", Name = "StoreHeaderById"), Authorize]
        public async Task<IActionResult> GetStoreHeader(Guid id)
        {
            var storeHeader = await _repository.StoreHeader.GetStoreHeaderAsync(id, trackChanges: false);
            if (storeHeader == null)
            {
                _logger.LogInfo($"StoreHeader with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            else
            {
                var storeHeaderDto = _mapper.Map<StoreHeaderDto>(storeHeader);
                return Ok(storeHeaderDto);
            }
        }

        [HttpGet("collection/({ids})", Name = "StoreHeaderCollection"), Authorize]
        public async Task<IActionResult> GetStoreHeaderCollection([ModelBinder(BinderType = typeof(ArrayModelBinder))]IEnumerable<Guid> ids)
        {
            if(ids == null)
            {
                _logger.LogError("Parameter ids is null");
                return BadRequest("Parameter ids is null");
            }

            var storeHeaderEntities = await _repository.StoreHeader.GetByIdsAsync(ids, trackChanges: false);

            if(ids.Count() != storeHeaderEntities.Count())
            {
                _logger.LogError("Some ids are not valid in a collection");
                return NotFound();
            }

            var companiesToReturn = _mapper.Map<IEnumerable<StoreHeaderDto>>(storeHeaderEntities);
            return Ok(companiesToReturn);
        }

        /// <summary>
        /// Creates a newly created storeHeader
        /// </summary>
        /// <param name="storeHeader"></param>
        /// <returns>A newly created storeHeader</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>
        /// <response code="422">If the model is invalid</response>
        [HttpPost(Name = "CreateStoreHeader"), Authorize]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(422)]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateStoreHeader([FromBody]StoreHeaderForCreationDto storeHeader)
        {
            var storeHeaderEntity = _mapper.Map<StoreHeader>(storeHeader);

            _repository.StoreHeader.CreateStoreHeader(storeHeaderEntity);
            await _repository.SaveAsync();

            var storeHeaderToReturn = _mapper.Map<StoreHeaderDto>(storeHeaderEntity);

            return CreatedAtRoute("StoreHeaderById", new { id = storeHeaderToReturn.Id }, storeHeaderToReturn);
        }

        [HttpPost("collection"), Authorize]
        public async Task<IActionResult> CreateStoreHeaderCollection([FromBody] IEnumerable<StoreHeaderForCreationDto> storeHeaderCollection)
        {
            if(storeHeaderCollection == null)
            {
                _logger.LogError("StoreHeader collection sent from client is null.");
                return BadRequest("StoreHeader collection is null");
            }

            var storeHeaderEntities = _mapper.Map<IEnumerable<StoreHeader>>(storeHeaderCollection);
            foreach (var storeHeader in storeHeaderEntities)
            {
                _repository.StoreHeader.CreateStoreHeader(storeHeader);
            }

            await _repository.SaveAsync();

            var storeHeaderCollectionToReturn = _mapper.Map<IEnumerable<StoreHeaderDto>>(storeHeaderEntities);
            var ids = string.Join(",", storeHeaderCollectionToReturn.Select(c => c.Id));

            return CreatedAtRoute("StoreHeaderCollection", new { ids }, storeHeaderCollectionToReturn);
        }

        [HttpDelete("{id}"), Authorize]
        [ServiceFilter(typeof(ValidateStoreExistsAttribute))]
        public async Task<IActionResult> DeleteStoreHeader(Guid id)
        {
            var storeHeader = HttpContext.Items["storeHeader"] as StoreHeader;

            _repository.StoreHeader.DeleteStoreHeader(storeHeader);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("{id}"), Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateStoreExistsAttribute))]
        public async Task<IActionResult> UpdateStoreHeader(Guid id, [FromBody] StoreHeaderForUpdateDto storeHeader)
        {
            var storeHeaderEntity = HttpContext.Items["storeHeader"] as StoreHeader;

            _mapper.Map(storeHeader, storeHeaderEntity);
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