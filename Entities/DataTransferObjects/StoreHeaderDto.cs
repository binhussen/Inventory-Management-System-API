using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class StoreHeaderDto
    {
        public Guid Id { get; set; }
        public Guid SupplierId { get; set; }
        public Guid ReciverId { get; set; }
        public DateTime Date { get; set; }
        public string GraNo { get; set; }
        public string Pox { get; set; }
        public Guid CheckedBy { get; set; }
        public Guid AcceptedBy { get; set; }
        public Guid InspectedBy { get; set; }
        public string CreatedByUser { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string ModifiedByUser { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
    }
}
