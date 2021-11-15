using Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class StoreItem:BaseEntity
    {
        [Column("StoreItemId")]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ItemSpecification { get; set; }
        public string Unit { get; set; }
        public int QtyOrdered { get; set; }
        public int QtyReceived { get; set; }
        public int QtyRemain { get; set; }
        public int UnitPrice { get; set; }
        public int TotalPrice { get; set; }
        public int Status { get; set; }
        [ForeignKey(nameof(StoreHeader))]
        public Guid StoreHeaderId { get; set; }
        public StoreHeader StoreHeader { get; set; }
    }
}
