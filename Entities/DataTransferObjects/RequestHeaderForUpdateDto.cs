using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class RequestHeaderForUpdateDto : RequestHeaderForManipulationDto
    {
        public IEnumerable<RequestItemForCreationDto> RequestItems { get; set; }
    }
}
