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
    public class RequestHeaderRepository : RepositoryBase<RequestHeader>, IRequestHeaderRepository
    {
        public RequestHeaderRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<PagedList<RequestHeader>> GetRequestsAsync(OrderParameters orderParameters, bool trackChanges)
        {
            var request = await FindAll(trackChanges)
           .OrderBy(c => c.CreatedByUser)
           .ToListAsync();

            return PagedList<RequestHeader>
                .ToPagedList(request, orderParameters.PageNumber, orderParameters.PageSize);
        }
        /*public async Task<IEnumerable<RequestHeader>> GetAllRequestHeadersAsync(bool trackChanges) =>
           await FindAll(trackChanges)
           .OrderBy(c => c.Id)
           .ToListAsync();*/

        public async Task<RequestHeader> GetRequestHeaderAsync(Guid RequestHeaderId, bool trackChanges) =>
            await FindByCondition(c => c.Id.Equals(RequestHeaderId), trackChanges)
            .SingleOrDefaultAsync();

        public async Task<IEnumerable<RequestHeader>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) =>
            await FindByCondition(x => ids.Contains(x.Id), trackChanges)
            .ToListAsync();

        public void CreateRequestHeader(RequestHeader RequestHeader) => Create(RequestHeader);

        public void DeleteRequestHeader(RequestHeader RequestHeader)
        {
            Delete(RequestHeader);
        }
    }
}
