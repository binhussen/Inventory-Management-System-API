using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class CompanyDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }
        public string CreatedByUser { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string ModifiedByUser { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
    }
}
