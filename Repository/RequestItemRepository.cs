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
    public class RequestItemRepository : RepositoryBase<RequestItem>, IRequestItemRepository
    {
        public RequestItemRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<PagedList<RequestItem>> GetRequestItemsAsync(Guid RequestHeaderId, RequestItemParameters requestItemParameters, bool trackChanges)
        {
            var storeItems = await FindByCondition(e =>  e.RequestHeaderId.Equals(RequestHeaderId), trackChanges)
                /*.FilterRequestItems(storeItemParameters.min, storeItemParameters.max)*/
                .Search(requestItemParameters.SearchTerm)
                .Sort(requestItemParameters.OrderBy)
                .ToListAsync();
            return PagedList<RequestItem>
                .ToPagedList(storeItems, requestItemParameters.PageNumber, requestItemParameters.PageSize);
        }
        
        public async Task<RequestItem> GetRequestItemAsync(Guid RequestHeaderId, Guid id, bool trackChanges) =>
            await FindByCondition(e => e.RequestHeaderId.Equals(RequestHeaderId) && e.Id.Equals(id), trackChanges)
            .SingleOrDefaultAsync();


        public void DeleteRequestItem(RequestItem storeItem)
        {
            Delete(storeItem);
        }

        public void CreateRequestItemForRequestHeader(Guid RequestHeaderId, RequestItem RequestItem)
        {
            RequestItem.RequestHeaderId = RequestHeaderId;
            Create(RequestItem);
        }
    }
}
