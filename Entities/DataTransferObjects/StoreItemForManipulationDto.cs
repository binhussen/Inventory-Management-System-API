using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public abstract class StoreItemForManipulationDto
    {
        public string Name { get; set; }
        public string ItemSpecification { get; set; }
        public string Unit { get; set; }
        public int QtyOrdered { get; set; }
        public int QtyReceived { get; set; }
        public int UnitPrice { get; set; }
    }
}
