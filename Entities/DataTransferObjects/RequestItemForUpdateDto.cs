using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class RequestItemForUpdateDto : RequestItemForManipulationDto
    { 
        public int Status { get; set; }
    }
}
