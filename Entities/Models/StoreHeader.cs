using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class StoreHeader
    {
        [Column("StoreHeaderId")]
        public Guid Id { get; set; }
        public Guid SupplierId { get; set; }
        public Guid ReciverId { get; set; }
        public DateTime Date { get; set; }
        public string GraNo { get; set; }
        public string Pox { get; set; }
        public Guid CheckedBy { get; set; }
        public Guid AcceptedBy { get; set; }
        public Guid InspectedBy { get; set; }
        public ICollection<StoreItem> StoreItems { get; set; }
    }
}
