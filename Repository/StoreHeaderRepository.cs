using Contracts;
using Entities;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class StoreHeaderRepository : RepositoryBase<StoreHeader>, IStoreHeaderRepository
    {
        public StoreHeaderRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<PagedList<StoreHeader>> GetStoresAsync(StoreItemParameters storeParameters, bool trackChanges)
        {
            var stores = await FindAll(trackChanges)
           .OrderBy(c => c.SupplierId)
           .ToListAsync();

            return PagedList<StoreHeader>
                .ToPagedList(stores, storeParameters.PageNumber, storeParameters.PageSize);
        }
        /*public async Task<IEnumerable<StoreHeader>> GetAllStoreHeadersAsync(bool trackChanges) =>
           await FindAll(trackChanges)
           .OrderBy(c => c.Id)
           .ToListAsync();*/

        public async Task<StoreHeader> GetStoreHeaderAsync(Guid storeHeaderId, bool trackChanges) =>
            await FindByCondition(c => c.Id.Equals(storeHeaderId), trackChanges)
            .SingleOrDefaultAsync();

        public async Task<IEnumerable<StoreHeader>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) =>
            await FindByCondition(x => ids.Contains(x.Id), trackChanges)
            .ToListAsync();

        public void CreateStoreHeader(StoreHeader storeHeader) => Create(storeHeader);

        public void DeleteStoreHeader(StoreHeader storeHeader)
        {
            Delete(storeHeader);
        }
    }
}
