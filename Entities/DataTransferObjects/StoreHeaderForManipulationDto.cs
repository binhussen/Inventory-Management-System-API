using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObjects
{
    public abstract class StoreHeaderForManipulationDto
    {
        public Guid SupplierId { get; set; }
        public Guid ReciverId { get; set; }
        public DateTime Date { get; set; }
        public string GraNo { get; set; }
        public string Pox { get; set; }
        public Guid CheckedBy { get; set; }
        public Guid AcceptedBy { get; set; }
        public Guid InspectedBy { get; set; }
    }
}
