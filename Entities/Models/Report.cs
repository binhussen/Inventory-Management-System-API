using Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Report:BaseEntity
    {
        public Guid Id { get; set; }
        public string BookOwner { get; set; }
        public string Branch { get; set; }
        public string MemeberPhone { get; set; }
        public string BookNumber { get; set; }
        public string Service { get; set; }
    }
}
