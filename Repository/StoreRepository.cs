using Contracts;
using Entities;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using Repository.Extensions;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class StoreRepository : RepositoryBase<StoreItem>, IStoreRepository
    {
        public StoreRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<StoreItem> EditStoreItemAsync(Guid id, bool trackChanges) =>
            await FindByCondition(e => e.Id.Equals(id), trackChanges)
            .SingleOrDefaultAsync();
        public async Task<PagedList<StoreItem>> GetStoresAsync(StoreItemParameters StoreItemParameters, bool trackChanges)
        {
            var StoreItems = await FindByCondition(e => e.Status.Equals(StoreItemParameters.Status), trackChanges)
                /*.FilterStoreItems(x=>x..Equals(StoreItemParameters.Status))*/
                .Search(StoreItemParameters.SearchTerm)
                .Sort(StoreItemParameters.OrderBy)
                .ToListAsync();

            return PagedList<StoreItem>
                .ToPagedList(StoreItems, StoreItemParameters.PageNumber, StoreItemParameters.PageSize);
        }
    }
}
