using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public abstract class RequestItemForManipulationDto
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Use { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public string BudgetCode { get; set; }
    }
}
