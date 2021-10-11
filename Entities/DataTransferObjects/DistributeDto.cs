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
    }
}
