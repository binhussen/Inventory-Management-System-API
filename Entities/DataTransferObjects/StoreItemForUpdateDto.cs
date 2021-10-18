using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class StoreItemForUpdateDto : StoreItemForManipulationDto
    {
        public int Status { get; set; }
    }
}
