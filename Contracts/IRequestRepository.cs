using Entities.DataTransferObjects;
using Entities.Models;
using Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRequestRepository
    {
        void Approve(Guid RequestHeaderId, Guid id, RequestItemForApprovementDto requestItemForApprovement);
        void Reject(Guid RequestHeaderId, Guid id,RequestItemForRejectDto requestItemForReject, bool trackChanges);
        void BudjetCode(Guid RequestHeaderId, Guid id, RequestItemForBudgetCodeDto requestItemForBudgetCode, bool trackChanges);
    }
}
