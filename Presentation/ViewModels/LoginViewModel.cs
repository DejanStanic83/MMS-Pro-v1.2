using Domain.Common;
using System.Threading.Tasks;
using MMS.Application.Services;


namespace MMS.Presentation.ViewModels
{
    public class LoginViewModel
    {
        private readonly IUserSession _userSession;
        private readonly IAuthService _authService;

        public LoginViewModel(IUserSession userSession, IAuthService authService)
        {
            _userSession = userSession;
            _authService = authService;
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            var user = await _authService.AuthenticateAsync(username, password);
            if (user != null)
            {
                _userSession.SetUser(user.Id, user.UserName, user.DisplayName, user.Role);
                return true;
            }
            return false;
        }
    }
}