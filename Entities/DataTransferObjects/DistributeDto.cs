using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class DistributeDto
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public Guid EmployeeID { get; set; }
        public Guid StoreItemId { get; set; }
        public string CreatedByUser { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string ModifiedByUser { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
    }
}
