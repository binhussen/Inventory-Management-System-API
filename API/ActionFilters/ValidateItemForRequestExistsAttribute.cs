using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ActionFilters
{
    public class ValidateItemForRequestExistsAttribute : IAsyncActionFilter
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public ValidateItemForRequestExistsAttribute(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var method = context.HttpContext.Request.Method;
            var trackChanges = (method.Equals("PUT") || method.Equals("PATCH")) ? true : false;

            var requestId = (Guid)context.ActionArguments["requestHeaderId"];
            var request = await _repository.RequestHeader.GetRequestHeaderAsync(requestId, false);

            if (request == null)
            {
                _logger.LogInfo($"Request with id: {requestId} doesn't exist in the database.");
                context.Result = new NotFoundResult();
                return;
            }

            var id = (Guid)context.ActionArguments["id"];
            var item = await _repository.RequestItem.GetRequestItemAsync(requestId, id, trackChanges);

            if(item == null)
            {
                _logger.LogInfo($"Item with id: {id} doesn't exist in the database.");
                context.Result = new NotFoundResult();
            }
            else
            {
                context.HttpContext.Items.Add("requestItem", item);
                await next();
            }
        }
    }
}
