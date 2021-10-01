using Entities.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IStoreHeaderRepository
    {
        Task<IEnumerable<StoreHeader>> GetAllStoreHeadersAsync(bool trackChanges);
        Task<StoreHeader> GetStoreHeaderAsync(Guid storeHeaderId, bool trackChanges);
        void CreateStoreHeader(StoreHeader storeHeader);
        Task<IEnumerable<StoreHeader>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        void DeleteStoreHeader(StoreHeader storeHeader);
    }
}
