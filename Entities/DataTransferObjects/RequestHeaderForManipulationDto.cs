using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObjects
{
    public abstract class RequestHeaderForManipulationDto
    {
        public Guid AskedBy { get; set; }
        public Guid CheckedBy { get; set; }
        public Guid ApprovedBy { get; set; }
        public DateTime Date { get; set; }
    }
}
