using System.Threading.Tasks;
using Moq;
using Xunit;
using MMS.Presentation.ViewModels;
using MMS.Application.Services;
using Domain.Common;
// Use an alias to resolve ambiguity
using AppUserDto = MMS.Application.DTOs.UserDto;

namespace MMS.Presentation.Tests
{
    /// <summary>
    /// Test klasa za napredne scenarije LoginViewModel-a.
    /// Proverava ponašanje login logike sa validnim i nevalidnim kredencijalima.
    /// </summary>
    public class LoginViewModelAdvancedTests
    {
        /// <summary>
        /// Testira da LoginAsync vraæa true i postavlja korisnika u sesiju kada su kredencijali ispravni.
        /// </summary>
        [Fact]
        public async Task LoginAsync_WithValidCredentials_ReturnsTrueAndSetsUser()
        {
            // Arrange
            var mockSession = new Mock<IUserSession>();
            var mockAuth = new Mock<IAuthService>();
            var user = new AppUserDto { Id = 1, UserName = "test", DisplayName = "Test User", Role = "Admin" };
            mockAuth.Setup(a => a.AuthenticateAsync("test", "pass")).Returns(Task.FromResult(user));

            var vm = new LoginViewModel(mockSession.Object, mockAuth.Object);

            // Act
            var result = await vm.LoginAsync("test", "pass");

            // Assert
            Assert.True(result);
            mockSession.Verify(s => s.SetUser(1, "test", "Test User", "Admin"), Times.Once);
        }

        /// <summary>
        /// Testira da LoginAsync vraæa false i ne postavlja korisnika u sesiju kada su kredencijali pogrešni.
        /// </summary>
        [Fact]
        public async Task LoginAsync_WithInvalidCredentials_ReturnsFalseAndDoesNotSetUser()
        {
            // Arrange
            var mockSession = new Mock<IUserSession>();
            var mockAuth = new Mock<IAuthService>();
            mockAuth.Setup(a => a.AuthenticateAsync("bad", "bad")).Returns(Task.FromResult<AppUserDto>(null));

            var vm = new LoginViewModel(mockSession.Object, mockAuth.Object);

            // Act
            var result = await vm.LoginAsync("bad", "bad");

            // Assert
            Assert.False(result);
            mockSession.Verify(s => s.SetUser(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Never);
        }
    }
}