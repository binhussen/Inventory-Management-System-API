using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class RequestHeaderDto
    {
        public Guid Id { get; set; }
        public Guid AskedBy { get; set; }
        public Guid CheckedBy { get; set; }
        public Guid ApprovedBy { get; set; }
        public DateTime Date { get; set; }
        public string CreatedByUser { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string ModifiedByUser { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
    }
}
