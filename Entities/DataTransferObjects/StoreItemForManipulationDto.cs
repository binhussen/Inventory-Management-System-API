using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public abstract class StoreItemForManipulationDto
    {
        public string Name { get; set; }
        public string ItemSpecification { get; set; }
        public int Unit { get; set; }
        public int QtyOrdered { get; set; }
        public int QtyRecived { get; set; }
        public int UnitPrice { get; set; }
        public int TotalPrice { get; set; }
    }
}
