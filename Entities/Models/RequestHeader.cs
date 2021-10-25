using Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class RequestHeader:BaseEntity
    {
        [Column("RequestHeaderId")]
        public Guid Id { get; set; }
        public string BudgetCode { get; set; }
        public string BudgetBy { get; set; }
        public DateTimeOffset BudgetDate { get; set; }
        public int Status { get; set; }
        public ICollection<RequestItem> RequestItems { get; set; }
    }
}
