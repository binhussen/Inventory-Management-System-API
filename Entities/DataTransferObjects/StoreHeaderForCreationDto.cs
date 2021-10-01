using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public class StoreHeaderForCreationDto : StoreHeaderForManipulationDto
    {
        public IEnumerable<StoreItemForCreationDto> StoreItems { get; set; }
    }
}
