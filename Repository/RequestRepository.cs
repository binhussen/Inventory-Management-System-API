using Contracts;
using Entities;
using Entities.DataTransferObjects;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using Repository.Extensions;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class RequestRepository : RepositoryBase<RequestItem>, IRequestRepository
    {
        public RequestRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
        public void Approve(Guid RequestHeaderId, Guid id, RequestItemForApprovementDto requestItemForApprovement)
        {
            throw new NotImplementedException();
        }

        public void BudjetCode(Guid RequestHeaderId, Guid id, RequestItemForBudgetCodeDto requestItemForBudgetCode, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void Reject(Guid RequestHeaderId, Guid id, RequestItemForRejectDto requestItemForReject, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
