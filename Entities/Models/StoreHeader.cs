using Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class StoreHeader:BaseEntity
    {
        [Column("StoreHeaderId")]
        public Guid Id { get; set; }
        public Guid SupplierId { get; set; }
        public string GraNo { get; set; }
        public string StoreBy { get; set; }
        public int Status { get; set; }
        public DateTimeOffset StoreDate { get; set; }
        public ICollection<StoreItem> StoreItems { get; set; }
    }
}
