#nullable enable
using System.Collections.ObjectModel;
using MMS.Presentation.ViewModels;
using Xunit;

namespace MMS.Presentation.Tests
{
    /// <summary>
    /// Test klasa za ShellViewModel.
    /// Proverava inicijalizaciju menija, promenu stranica i PropertyChanged doga�aje.
    /// </summary>
    public class ShellViewModelTests
    {
        /// <summary>
        /// Testira da li su MenuItems inicijalizovani i sadr�e o�ekivane stavke.
        /// </summary>
        [Fact]
        public void MenuItems_AreInitialized()
        {
            var vm = new ShellViewModel();
            Assert.NotNull(vm.MenuItems);
            Assert.True(vm.MenuItems.Count > 0);
            Assert.Contains("Klijenti", vm.MenuItems);
        }

        /// <summary>
        /// Testira da se SelectedPage mo�e postaviti i pro�itati.
        /// </summary>
        [Fact]
        public void SelectedPage_CanBeSetAndRead()
        {
            var vm = new ShellViewModel();
            vm.SelectedPage = "Objekti";
            Assert.Equal("Objekti", vm.SelectedPage);
        }

        /// <summary>
        /// Testira da promena SelectedPage podi�e PropertyChanged doga�aj.
        /// </summary>
        [Fact]
        public void Changing_SelectedPage_RaisesPropertyChanged()
        {
            var vm = new ShellViewModel();
            string? changedProp = null;
            vm.PropertyChanged += (s, e) => changedProp = e.PropertyName;

            vm.SelectedPage = "Klijenti";

            Assert.Equal("SelectedPage", changedProp);
        }

        /// <summary>
        /// Testira da MenuItems sadr�i o�ekivane stranice.
        /// </summary>
        [Fact]
        public void MenuItems_Contains_ExpectedPages()
        {
            var vm = new ShellViewModel();
            var expectedPages = new[] { "Klijenti", "Objekti", "Usluge" };
            foreach (var page in expectedPages)
            {
                Assert.Contains(page, vm.MenuItems);
            }
        }

        /// <summary>
        /// Testira da postavljanje nepostoje�e stranice u SelectedPage ne baca izuzetak.
        /// </summary>
        [Fact]
        public void Setting_Invalid_SelectedPage_DoesNotThrow()
        {
            var vm = new ShellViewModel();
            var ex = Record.Exception(() => vm.SelectedPage = "NepostojecaStranica");
            Assert.Null(ex);
        }
    }
}