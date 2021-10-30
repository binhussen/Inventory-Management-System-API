using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class RequestItemDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Use { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public int TotalPrice { get; set; }
        public int Status { get; set; }
        public string ApprovedBy { get; set; }
        public DateTimeOffset ApprovedDate { get; set; }
        public string DistributeBy { get; set; }
        public DateTimeOffset DistributeDate { get; set; }
        public int ApprovedQuantity { get; set; }
        public Guid StoreItemId { get; set; }
        public string CreatedByUser { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string ModifiedByUser { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
        public string BuyBy { get; set; }
        public DateTimeOffset BuyDate { get; set; }
    }
}
