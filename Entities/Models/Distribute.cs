using Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Distribute : BaseEntity
    {
        [Column("DistributeId")]
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        [ForeignKey(nameof(Employee))]
        public Guid EmployeeID { get; set; }
        [ForeignKey(nameof(StoreItem))]
        public Guid StoreItemId { get; set; }
    }
}
