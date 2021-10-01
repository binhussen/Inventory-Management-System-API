using Entities.Models;
using Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IStoreItemRepository
    {
        Task<PagedList<StoreItem>> GetStoreItemsAsync(Guid storeHeaderId, StoreItemParameters storeItemsParameters, bool trackChanges);
        Task<StoreItem> GetStoreItemAsync(Guid storeHeaderId, Guid id, bool trackChanges);
        void CreateStoreItemForStoreHeader(Guid storeHeaderId, StoreItem storeItem);
        void DeleteStoreItem(StoreItem storeItem);
    }
}
