using System.Collections.ObjectModel;
using MMS.Presentation.ViewModels;
using Xunit;

namespace MMS.Presentation.Tests
{
    public class ShellViewModelTests
    {
        [Fact]
        public void MenuItems_AreInitialized()
        {
            var vm = new ShellViewModel();
            Assert.NotNull(vm.MenuItems);
            Assert.True(vm.MenuItems.Count > 0);
            Assert.Contains("Klijenti", vm.MenuItems);
        }

        [Fact]
        public void SelectedPage_CanBeSetAndRead()
        {
            var vm = new ShellViewModel();
            vm.SelectedPage = "Objekti";
            Assert.Equal("Objekti", vm.SelectedPage);
        }
    }
}