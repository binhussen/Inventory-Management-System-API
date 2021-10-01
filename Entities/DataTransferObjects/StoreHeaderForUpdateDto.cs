using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class StoreHeaderForUpdateDto : StoreHeaderForManipulationDto
    {
        public IEnumerable<StoreItemForCreationDto> StoreItems { get; set; }
    }
}
