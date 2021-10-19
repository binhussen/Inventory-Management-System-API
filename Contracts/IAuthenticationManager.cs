using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IAuthenticationManager
    {
        Task<bool> ValidateUser(UserForAuthenticationDto userForAuth);
        Task<object> CreateToken();

        Task<SignInResult> Login(UserForAuthenticationDto user);
    }
}
