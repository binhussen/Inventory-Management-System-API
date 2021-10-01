using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class RequestItemDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Dicription { get; set; }
        public string Use { get; set; }
        public int Qty { get; set; }
        public int UnitPrice { get; set; }
        public int TotalPrice { get; set; }
        public string BudgetCode { get; set; }
    }
}
