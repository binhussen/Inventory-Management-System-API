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
        public Guid AskedBy { get; set; }
        public Guid CheckedBy { get; set; }
        public Guid ApprovedBy { get; set; }
        public DateTime Date { get; set; }
        public ICollection<RequestItem> RequestItems { get; set; }
    }
}
