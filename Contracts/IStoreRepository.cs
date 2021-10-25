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
        Task<StoreItem> EditStoreItemAsync(Guid id, bool trackChanges);
    }
}
