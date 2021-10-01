using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ActionFilters
{
    public class ValidateItemForStoreExistsAttribute : IAsyncActionFilter
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public ValidateItemForStoreExistsAttribute(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var method = context.HttpContext.Request.Method;
            var trackChanges = (method.Equals("PUT") || method.Equals("PATCH")) ? true : false;

            var storeId = (Guid)context.ActionArguments["storeHeaderId"];
            var store = await _repository.StoreHeader.GetStoreHeaderAsync(storeId, false);

            if (store == null)
            {
                _logger.LogInfo($"store with id: {storeId} doesn't exist in the database.");
                context.Result = new NotFoundResult();
                return;
            }

            var id = (Guid)context.ActionArguments["id"];
            var Item = await _repository.StoreItem.GetStoreItemAsync(storeId, id, trackChanges);

            if(Item == null)
            {
                _logger.LogInfo($"Item with id: {id} doesn't exist in the database.");
                context.Result = new NotFoundResult();
            }
            else
            {
                context.HttpContext.Items.Add("storeItem", Item);
                await next();
            }
        }
    }
}
