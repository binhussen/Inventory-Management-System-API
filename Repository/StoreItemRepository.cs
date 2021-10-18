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
    public class StoreItemRepository : RepositoryBase<StoreItem>, IStoreItemRepository
    {
        public StoreItemRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<PagedList<StoreItem>> GetStoreItemsAsync(Guid storeHeaderId, StoreItemParameters StoreItemParameters, bool trackChanges)
        {
            var StoreItems = await FindByCondition(e => e.StoreHeaderId.Equals(storeHeaderId), trackChanges)
                /*.FilterStoreItems(StoreItemParameters.min, StoreItemParameters.max)*/
                .Search(StoreItemParameters.SearchTerm)
                .Sort(StoreItemParameters.OrderBy)
                .ToListAsync();

            return PagedList<StoreItem>
                .ToPagedList(StoreItems, StoreItemParameters.PageNumber, StoreItemParameters.PageSize);
        }
        
        public async Task<StoreItem> GetStoreItemAsync(Guid storeHeaderId, Guid id, bool trackChanges) =>
            await FindByCondition(e => e.StoreHeaderId.Equals(storeHeaderId) && e.Id.Equals(id), trackChanges)
            .SingleOrDefaultAsync();

        public void CreateStoreItemForStoreHeader(Guid storeHeaderId, StoreItem StoreItem)
        {
            StoreItem.StoreHeaderId = storeHeaderId;
            Create(StoreItem);
        }

        public void DeleteStoreItem(StoreItem StoreItem)
        {
            Delete(StoreItem);
        }

    }
}
