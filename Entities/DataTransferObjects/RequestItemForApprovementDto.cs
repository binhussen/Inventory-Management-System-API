using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class RequestItemForApprovementDto
    {
        public string BudgetCode { get; set; }
        public int Status { get; set; }
        public int ApprovedQuantity { get; set; }
        public Guid StoreItemId { get; set; }
    }
}
