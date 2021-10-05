using Contracts;
using Entities.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class CurrentUser : BaseEntity, ICurrentUser
    {
        private readonly IHttpContextAccessor _httpContextAccessor;


        public CurrentUser(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

       /* public BaseEntity AuditCreate()
        {
            var currentTime = DateTimeOffset.UtcNow;
            var audit = new BaseEntity
            {
                CreatedByUser=_currentUser.GetCurrentUsername(),
                CreatedDate=currentTime
            };
            
            return audit;
        }
        public BaseEntity AuditUpdate()
        {
            var audit = new BaseEntity
            {
            };

            return audit;
        }
       */
        public string GetCurrentUsername()
        {
            return _httpContextAccessor.HttpContext.User.Identity.Name;
        }
    }
}
