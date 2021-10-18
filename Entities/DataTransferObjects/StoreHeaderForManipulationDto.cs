using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObjects
{
    public abstract class StoreHeaderForManipulationDto
    {
        public Guid SupplierId { get; set; }
        public string GraNo { get; set; }
    }
}
