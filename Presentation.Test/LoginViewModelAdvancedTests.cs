using Xunit;
using Presentation.ViewModels;
using System.Threading.Tasks;

namespace Presentation.Test
{
    public class LoginViewModelAdvancedTests
    {
        [Fact]
        public void LoginCommand_CannotExecute_WhenUsernameOrPasswordIsEmpty()
        {
            // Arrange
            var vm = new LoginViewModel();

            // Act & Assert
            vm.Username = "";
            vm.Password = "";
            Assert.False(vm.LoginCommand.CanExecute(null));

            vm.Username = "user";
            vm.Password = "";
            Assert.False(vm.LoginCommand.CanExecute(null));

            vm.Username = "";
            vm.Password = "pass";
            Assert.False(vm.LoginCommand.CanExecute(null));
        }

        [Fact]
        public void LoginCommand_CanExecute_WhenUsernameAndPasswordAreFilled()
        {
            // Arrange
            var vm = new LoginViewModel
            {
                Username = "user",
                Password = "pass"
            };

            // Act & Assert
            Assert.True(vm.LoginCommand.CanExecute(null));
        }

        [Fact]
        public async Task LoginCommand_Executes_LoginAsync_AndSetsIsBusy()
        {
            // Arrange
            var vm = new LoginViewModel
            {
                Username = "user",
                Password = "pass"
            };

            bool wasBusy = false;
            vm.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(vm.IsBusy) && vm.IsBusy)
                    wasBusy = true;
            };

            // Act
            await Task.Run(() => vm.LoginCommand.Execute(null));

            // Assert
            Assert.True(wasBusy);
            // Ovde možeš dodati još asserta za rezultat logovanja, npr. vm.IsLoggedIn ili slièno
        }
    }
}