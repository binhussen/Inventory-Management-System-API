using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class UserDto
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool? IsEnabled { get; set; }
        public DateTimeOffset LockoutEnd { get; set; }
        public bool AccessFailedCount { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
