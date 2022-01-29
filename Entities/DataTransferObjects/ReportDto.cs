using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class ReportDto
    {
        public Guid Id { get; set; }
        public string BookOwner { get; set; }
        public string Branch { get; set; }
        public string MemeberPhone { get; set; }
        public string BookNumber { get; set; }
        public string Service { get; set; }
        public string CreatedByUser { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string ModifiedByUser { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
    }
}
