using System.Threading.Tasks;
using ApiJWTAuthentication.Models;

namespace ApiJWTAuthentication.Services
{
    public interface IUserService
    {
        Task<string> RegisterAsync(RegisterModel model);

        Task<AuthenticationModel> GetTokenAsync (TokenRequestModel model);
    }
}