/*using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SignInManagerCore : ISignInManagerCore
    {
        private readonly SignInManager<User> _signInManager;
        private readonly ILoggerManager _loggerManager;
        private readonly IConfiguration _configuration;
        private User _user;

        public SignInManagerCore(IConfiguration configuration,SignInManager<User> signInManager, ILoggerManager loggerManager)
        {
            _signInManager = signInManager;
            _loggerManager = loggerManager;
            _configuration = configuration;
        }

        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
            _loggerManager.LogInfo("User logged out.");
        }

        public async Task<SignInResult> SignIn(UserForAuthenticationDto userForAuthenticationDto)
        {
            var _user = await _userManager.FindByNameAsync(userForAuthenticationDto.UserName);
            var result = await _signInManager.PasswordSignInAsync(_user, userForAuthenticationDto.Password, true, false);
            return result.Succeeded;
        }

        public async Task<object> CreateToken()
        {
            var signingCredentials = GetSigningCredentials();
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims);

            return (new
            {
                token = new JwtSecurityTokenHandler().WriteToken(tokenOptions),
                expiration = tokenOptions.ValidTo
            });
        }

        private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("SECRET"));
            var secret = new SymmetricSecurityKey(key);

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private async Task<List<Claim>> GetClaims()
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, _user.UserName)
            };

            *//*var roles = await _userManager.GetRolesAsync(_user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }*//*

            return claims;
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");

            var tokenOptions = new JwtSecurityToken
            (
                issuer: jwtSettings.GetSection("validIssuer").Value,
                audience: jwtSettings.GetSection("validAudience").Value,
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings.GetSection("expires").Value)),
                signingCredentials: signingCredentials
            );

            return tokenOptions;

        }
    }
}
*/