using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class RequestItem
    {
        [Column("RequestItemId")]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Dicription { get; set; }
        public string Use { get; set; }
        public int Qty { get; set; }
        public int UnitPrice { get; set; }
        public int TotalPrice { get; set; }
        public string BudgetCode { get; set; }
        [ForeignKey(nameof(RequestHeader))]
        public Guid RequestHeaderId { get; set; }
        public RequestHeader RequestHeader { get; set; }
    }
}
