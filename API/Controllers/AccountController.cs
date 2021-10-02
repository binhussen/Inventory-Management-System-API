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
        public AccountController(ILoggerManager logger, IMapper mapper, UserManager<User> userManager, RepositoryContext repositoryContext)
        {
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
            _repositoryContext=repositoryContext;
        }
        
        [HttpGet(Name = "users"), Authorize]
        public async Task<IActionResult> GetListUsers()
        {
            var users = _repositoryContext.Users.ToList();
            var userDto = _mapper.Map<IEnumerable<UserDto>>(users);

            return Ok(users);
        }
    }
}