using MMS.Application.DTOs;
using System.Threading.Tasks;

namespace MMS.Application.Services
{
    public interface IAuthService
    {
        Task<UserDto?> AuthenticateAsync(string username, string password);
    }
}