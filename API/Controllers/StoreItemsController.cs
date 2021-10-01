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

namespace API.Controllers
{
    [Route("api/storeItems/{storeHeaderId}/storeItems")]
    [ApiController]
    public class StoreItemsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public StoreItemsController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [HttpHead]
        public async Task<IActionResult> GetStoreItemsForStoreHeader(Guid storeHeaderId, [FromQuery] StoreItemParameters storeItemParameters)
        {
            /*if (!storeItemParameters.ValidAgeRange)
                return BadRequest("Max age can't be less than min age.");*/

            var storeHeader = await _repository.StoreHeader.GetStoreHeaderAsync(storeHeaderId, trackChanges: false);
            if (storeHeader == null)
            {
                _logger.LogInfo($"StoreHeader with id: {storeHeaderId} doesn't exist in the database.");
                return NotFound();
            }

            var storeItemsFromDb = await _repository.StoreItem.GetStoreItemsAsync(storeHeaderId, storeItemParameters, trackChanges: false);

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(storeItemsFromDb.MetaData));

            var storeItemsDto = _mapper.Map<IEnumerable<StoreItemDto>>(storeItemsFromDb);

            return Ok(storeItemsDto);
        }

        [HttpGet("{id}", Name = "GetStoreItemForStoreHeader")]
        public async Task<IActionResult> GetStoreItemForStoreHeader(Guid storeHeaderId, Guid id)
        {
            var storeHeader = await _repository.StoreHeader.GetStoreHeaderAsync(storeHeaderId, trackChanges: false);
            if (storeHeader == null)
            {
                _logger.LogInfo($"StoreHeader with id: {storeHeaderId} doesn't exist in the database.");
                return NotFound();
            }

            var storeItemDb = await _repository.StoreItem.GetStoreItemAsync(storeHeaderId, id, trackChanges: false);
            if (storeItemDb == null)
            {
                _logger.LogInfo($"StoreItem with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            var storeItem = _mapper.Map<StoreItemDto>(storeItemDb);

            return Ok(storeItem);
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateStoreItemForStoreHeader(Guid storeHeaderId, [FromBody] StoreItemForCreationDto storeItem)
        {
            var storeHeader = await _repository.StoreHeader.GetStoreHeaderAsync(storeHeaderId, trackChanges: false);
            if(storeHeader == null)
            {
                _logger.LogInfo($"StoreHeader with id: {storeHeaderId} doesn't exist in the database.");
                return NotFound();
            }

            var storeItemEntity = _mapper.Map<StoreItem>(storeItem);
            
            _repository.StoreItem.CreateStoreItemForStoreHeader(storeHeaderId, storeItemEntity);
            await _repository.SaveAsync();

            var storeItemToReturn = _mapper.Map<StoreItemDto>(storeItemEntity);

            return CreatedAtRoute("GetStoreItemForStoreHeader", new { storeHeaderId, id = storeItemToReturn.Id }, storeItemToReturn);
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidateItemForStoreExistsAttribute))]
        public async Task<IActionResult> DeleteStoreItemForStoreHeader(Guid storeHeaderId, Guid id)
        {
            var storeItemForStoreHeader = HttpContext.Items["storeItem"] as StoreItem;

            _repository.StoreItem.DeleteStoreItem(storeItemForStoreHeader);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateItemForStoreExistsAttribute))]
        public async Task<IActionResult> UpdateStoreItemForStoreHeader(Guid storeHeaderId, Guid id, [FromBody] StoreItemForUpdateDto storeItem)
        {
            var storeItemEntity = HttpContext.Items["storeItem"] as StoreItem;

            _mapper.Map(storeItem, storeItemEntity);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPatch("{id}")]
        [ServiceFilter(typeof(ValidateItemForStoreExistsAttribute))]
        public async Task<IActionResult> PartiallyUpdateStoreItemForStoreHeader(Guid storeHeaderId, Guid id, [FromBody] JsonPatchDocument<StoreItemForUpdateDto> patchDoc)
        {
            if(patchDoc == null)
            {
                _logger.LogError("patchDoc object sent from client is null.");
                return BadRequest("patchDoc object is null");
            }

            var storeItemEntity = HttpContext.Items["storeItem"] as StoreItem;

            var storeItemToPatch = _mapper.Map<StoreItemForUpdateDto>(storeItemEntity);

            patchDoc.ApplyTo(storeItemToPatch, ModelState);

            TryValidateModel(storeItemToPatch);

            if(!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the patch document");
                return UnprocessableEntity(ModelState);
            }

            _mapper.Map(storeItemToPatch, storeItemEntity);

            await _repository.SaveAsync();

            return NoContent();
        }
    }
}