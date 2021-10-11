using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public abstract class DistributeForManipulationDto
    {
        public int Quantity { get; set; }
        public Guid EmployeeID { get; set; }
        public Guid StoreItemId { get; set; }
    }
}
