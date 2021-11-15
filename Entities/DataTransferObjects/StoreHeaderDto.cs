using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class StoreHeaderDto
    {
        public Guid Id { get; set; }
        public Guid SupplierId { get; set; }
        public string GraNo { get; set; }
        public string StoreBy { get; set; }
        public int Status { get; set; }
        public DateTimeOffset StoreDate { get; set; }
        public string CreatedByUser { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string ModifiedByUser { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
    }
}
