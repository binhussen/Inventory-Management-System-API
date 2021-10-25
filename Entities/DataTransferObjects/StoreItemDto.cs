using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class StoreItemDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ItemSpecification { get; set; }
        public int Unit { get; set; }
        public int QtyOrdered { get; set; }
        public int QtyRecived { get; set; }
        public int QtyRemain { get; set; }
        public int UnitPrice { get; set; }
        public int TotalPrice { get; set; }
        public int Status { get; set; }
        public string CreatedByUser { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string ModifiedByUser { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
    }
}
