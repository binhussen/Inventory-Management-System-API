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
    }
}
