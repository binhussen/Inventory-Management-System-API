using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class RequestHeaderDto
    {
        public Guid Id { get; set; }
        public string BudgetCode { get; set; }
        public string BudgetBy { get; set; }
        public DateTimeOffset BudgetDate { get; set; }
        public int Status { get; set; }
        public string CreatedByUser { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string ModifiedByUser { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
    }
}
