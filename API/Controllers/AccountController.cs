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
        private readonly IPasswordHasher<User> _passwordHash;
        public AccountController(ILoggerManager logger, IMapper mapper, UserManager<User> userManager, RepositoryContext repositoryContext, IPasswordHasher<User> passwordHash)
        {
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
            _repositoryContext = repositoryContext;
            _passwordHash = passwordHash;
        }

        [HttpGet(Name = "users"), Authorize]
        public async Task<IActionResult> GetListUsers()
        {
            var users = _repositoryContext.Users.ToList();
            var userDto = _mapper.Map<IEnumerable<UserDto>>(users);
            /*role*/
            foreach (var user in users)
            {
                var role = await _userManager.GetRolesAsync(user);
                if (role!=null)
                {
                    foreach(var Dto in userDto)
                    {
                        if (Dto.Id == user.Id)
                        {
                            Dto.Roles = role;
                        }
                    }
                }
            }
            return Ok(userDto);
        }

        [HttpPut("{id}"), Authorize]
        public async Task<IActionResult> UpdateUser(Guid id, [FromBody] UserForUpdate userForUpdate)
        {
            var users = await _userManager.FindByIdAsync(id.ToString());
            if (users == null)
            {
                _logger.LogInfo($"User with id: {id} doesn't exist in the database.");
                return BadRequest();
            }
            var user = _mapper.Map(userForUpdate,users);

            IdentityResult result = await _userManager.UpdateAsync(user);
            /*role*/
            var roles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                await _userManager.RemoveFromRoleAsync(users, role);
            }
            await _userManager.AddToRolesAsync(users, userForUpdate.Roles);
            /**/
            if (result.Succeeded)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("lock/{id}"), Authorize]
        public async Task<IActionResult> AccountLockedOut(Guid id)
        {
            var users = await _userManager.FindByIdAsync(id.ToString());
            if (users == null)
            {
                _logger.LogInfo($"User with id: {id} doesn't exist in the database.");
                return BadRequest();
            }
            if (users.IsEnabled == null)
            {
                users.IsEnabled = true;
            }
            else
            {
                users.IsEnabled = !users.IsEnabled;
            }

            IdentityResult result = await _userManager.UpdateAsync(users);
            if (result.Succeeded)
            {
                return Ok($"User Status Activated : {users.IsEnabled}");
            }
            return BadRequest();
        }

        /*public async Task<IActionResult> ChangeRole(Guid id,string role)
        {
            var users = await _userManager.FindByIdAsync(id.ToString());
            if (users == null)
            {
                _logger.LogInfo($"User with id: {id} doesn't exist in the database.");
                return BadRequest();
            }
            if (!role.Any())
            {
                _logger.LogInfo("Roles doesn't exist in the registration DTO object, you have to Add later.");
                *//*await _userManager.AddToRoleAsync(user, "Manager");*//*
            }
            else
            {
                await _userManager.AddToRolesAsync(user, userForRegistration.Roles);
            }
        }*/
    }
}