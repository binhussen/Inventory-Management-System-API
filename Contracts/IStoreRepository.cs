using Entities.Models;
using Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IStoreRepository
    {
        Task<PagedList<StoreItem>> GetStoresAsync(StoreItemParameters storeItemsParameters, bool trackChanges);
        /*Task<StoreItem> GetStoreItemAsync(Guid storeHeaderId, Guid id, bool trackChanges);
        void CreateStoreItemForStoreHeader(Guid storeHeaderId, StoreItem storeItem);
        void DeleteStoreItem(StoreItem storeItem);*/
    }
}
