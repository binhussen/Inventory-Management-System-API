using Entities.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRequestHeaderRepository
    {
        Task<IEnumerable<RequestHeader>> GetAllRequestHeadersAsync(bool trackChanges);
        Task<RequestHeader> GetRequestHeaderAsync(Guid RequestHeaderId, bool trackChanges);
        void CreateRequestHeader(RequestHeader RequestHeader);
        Task<IEnumerable<RequestHeader>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        void DeleteRequestHeader(RequestHeader RequestHeader);
    }
}
