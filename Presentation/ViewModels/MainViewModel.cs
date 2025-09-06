using Domain.Common;

namespace MMS.Presentation.ViewModels
{
    public class MainViewModel
    {
        private readonly IUserSession _userSession;

        public MainViewModel(IUserSession userSession)
        {
            _userSession = userSession;
        }

        public string DisplayName => _userSession.DisplayName;
        public string Role => _userSession.Role;
        // Binduj na UI po potrebi

        public void Logout()
        {
            _userSession.Reset();
            // Dodaj logiku za prebacivanje na login ekran, èišæenje podataka, itd.
        }
    }
}