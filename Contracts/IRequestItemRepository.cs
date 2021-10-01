using Entities.Models;
using Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRequestItemRepository
    {
        Task<PagedList<RequestItem>> GetRequestItemsAsync(Guid RequestHeaderId, RequestItemParameters RequestItemParameters, bool trackChanges);
        Task<RequestItem> GetRequestItemAsync(Guid RequestHeaderId, Guid id, bool trackChanges);
        void CreateRequestItemForRequestHeader(Guid RequestHeaderId, RequestItem RequestItem);
        void DeleteRequestItem(RequestItem RequestItem);
    }
}
