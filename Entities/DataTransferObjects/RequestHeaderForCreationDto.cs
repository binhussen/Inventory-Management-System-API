using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public class RequestHeaderForCreationDto
    {
        public IEnumerable<RequestItemForCreationDto> RequestItems { get; set; }
    }
}
