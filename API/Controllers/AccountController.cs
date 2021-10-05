using AutoMapper;
using API.ActionFilters;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly RepositoryContext _repositoryContext;
        private readonly ICurrentUser _currentUser;
        public AccountController(ILoggerManager logger, IMapper mapper, UserManager<User> userManager, RepositoryContext repositoryContext, ICurrentUser currentUser)
        {
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
            _repositoryContext = repositoryContext;
            _currentUser = currentUser;
        }

        [HttpGet(Name = "users"), Authorize]
        public async Task<IActionResult> GetListUsers()
        {
            var users = (from user in _repositoryContext.Users
                         join userRoles in _repositoryContext.UserRoles on user.Id equals userRoles.UserId
                         join role in _repositoryContext.Roles on userRoles.RoleId equals role.Id
                         select new { Id = user.Id,
                             FirstName = user.FirstName,
                             LastName = user.LastName,
                             UserName = user.UserName,
                             Email = user.Email,
                             PhoneNumber = user.PhoneNumber,
                             Roles = role.Name,
                             status = role.Name
                         }).ToList();
            /*var users = _repositoryContext.Users.ToList();*/
            /*var userDto = _mapper.Map<IEnumerable<UserDto>>(users);*/
            return Ok(users);
        }

        [HttpGet("username")]
        public async Task<IActionResult> GetVurrentUser()
        {
            return Ok(_currentUser.GetCurrentUsername());
        }
    }
}