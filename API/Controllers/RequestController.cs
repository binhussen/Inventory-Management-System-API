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
    [Route("api/requestitems/{requestheaderid}/requestitems")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public RequestController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpPut("approve/{id}"), Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateItemForRequestExistsAttribute))]
        public async Task<IActionResult> UpdateRequestItemForApprovement(Guid RequestHeaderId, Guid id, [FromBody] RequestItemForApprovementDto RequestItem)
        {
            var RequestItemEntity = HttpContext.Items["requestItem"] as RequestItem;

            _mapper.Map(RequestItem, RequestItemEntity);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("reject/{id}"), Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateItemForRequestExistsAttribute))]
        public async Task<IActionResult> UpdateRequestItemForReject(Guid RequestHeaderId, Guid id, [FromBody] RequestItemForRejectDto RequestItem)
        {
            var RequestItemEntity = HttpContext.Items["requestItem"] as RequestItem;

            _mapper.Map(RequestItem, RequestItemEntity);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("budject/{id}"), Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateItemForRequestExistsAttribute))]
        public async Task<IActionResult> UpdateRequestItemForBudjetCode(Guid RequestHeaderId, Guid id, [FromBody] RequestItemForRejectDto RequestItem)
        {
            var RequestItemEntity = HttpContext.Items["requestItem"] as RequestItem;

            _mapper.Map(RequestItem, RequestItemEntity);
            await _repository.SaveAsync();

            return NoContent();
        }
    }
}