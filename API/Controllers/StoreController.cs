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
    [Route("api/storeitems")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public StoreController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet, Authorize]
        [HttpHead]
        public async Task<IActionResult> GetStoreItems([FromQuery] StoreItemParameters storeItemParameters)
        {
            var storesFromDb = await _repository.Store.GetStoresAsync(storeItemParameters, trackChanges: false);

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(storesFromDb.MetaData));

            var storeItemsDto = _mapper.Map<IEnumerable<StoreItemDto>>(storesFromDb);

            return Ok(storeItemsDto);
        }
    }
}