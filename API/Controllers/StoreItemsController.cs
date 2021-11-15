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
    [Route("api/storeitems/{storeheaderid}/storeitems")]
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

        [HttpGet, Authorize]
        [HttpHead]
        public async Task<IActionResult> GetStoreItemsForStoreHeader(Guid storeheaderid, [FromQuery] StoreItemParameters storeItemParameters)
        {
            /*if (!storeItemParameters.ValidAgeRange)
                return BadRequest("Max age can't be less than min age.");*/

            var storeHeader = await _repository.StoreHeader.GetStoreHeaderAsync(storeheaderid, trackChanges: false);
            if (storeHeader == null)
            {
                _logger.LogInfo($"StoreHeader with id: {storeheaderid} doesn't exist in the database.");
                return NotFound();
            }

            var storeItemsFromDb = await _repository.StoreItem.GetStoreItemsAsync(storeheaderid, storeItemParameters, trackChanges: false);

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(storeItemsFromDb.MetaData));

            var storeItemsDto = _mapper.Map<IEnumerable<StoreItemDto>>(storeItemsFromDb);

            return Ok(storeItemsDto);
        }

        [HttpGet("{id}", Name = "GetStoreItemForStoreHeader"), Authorize]
        public async Task<IActionResult> GetStoreItemForStoreHeader(Guid storeheaderid, Guid id)
        {
            var storeHeader = await _repository.StoreHeader.GetStoreHeaderAsync(storeheaderid, trackChanges: false);
            if (storeHeader == null)
            {
                _logger.LogInfo($"StoreHeader with id: {storeheaderid} doesn't exist in the database.");
                return NotFound();
            }

            var storeItemDb = await _repository.StoreItem.GetStoreItemAsync(storeheaderid, id, trackChanges: false);
            if (storeItemDb == null)
            {
                _logger.LogInfo($"StoreItem with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            var storeItem = _mapper.Map<StoreItemDto>(storeItemDb);

            return Ok(storeItem);
        }

        [HttpPost, Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateStoreItemForStoreHeader(Guid storeheaderid, [FromBody] StoreItemForCreationDto storeItem)
        {
            var storeHeader = await _repository.StoreHeader.GetStoreHeaderAsync(storeheaderid, trackChanges: false);
            if(storeHeader == null)
            {
                _logger.LogInfo($"StoreHeader with id: {storeheaderid} doesn't exist in the database.");
                return NotFound();
            }

            var storeItemEntity = _mapper.Map<StoreItem>(storeItem);
            
            _repository.StoreItem.CreateStoreItemForStoreHeader(storeheaderid, storeItemEntity);
            storeItemEntity.TotalPrice = storeItemEntity.UnitPrice * storeItemEntity.QtyReceived;
            storeItemEntity.QtyRemain = storeItemEntity.QtyReceived;
            await _repository.SaveAsync();

            var storeItemToReturn = _mapper.Map<StoreItemDto>(storeItemEntity);

            return CreatedAtRoute("GetStoreItemForStoreHeader", new { storeheaderid, id = storeItemToReturn.Id }, storeItemToReturn);
        }

        [HttpDelete("{id}"), Authorize]
        [ServiceFilter(typeof(ValidateItemForStoreExistsAttribute))]
        public async Task<IActionResult> DeleteStoreItemForStoreHeader(Guid storeheaderid, Guid id)
        {
            var storeItemForStoreHeader = HttpContext.Items["storeItem"] as StoreItem;

            _repository.StoreItem.DeleteStoreItem(storeItemForStoreHeader);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("{id}"), Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateItemForStoreExistsAttribute))]
        public async Task<IActionResult> UpdateStoreItemForStoreHeader(Guid storeheaderid, Guid id, [FromBody] StoreItemForUpdateDto storeItem)
        {
            var storeItemEntity = HttpContext.Items["storeItem"] as StoreItem;

            _mapper.Map(storeItem, storeItemEntity);
            storeItemEntity.TotalPrice = storeItemEntity.UnitPrice * storeItemEntity.QtyReceived;
            storeItemEntity.QtyRemain = storeItemEntity.QtyReceived;
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPatch("{id}"), Authorize]
        [ServiceFilter(typeof(ValidateItemForStoreExistsAttribute))]
        public async Task<IActionResult> PartiallyUpdateStoreItemForStoreHeader(Guid storeheaderid, Guid id, [FromBody] JsonPatchDocument<StoreItemForUpdateDto> patchDoc)
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