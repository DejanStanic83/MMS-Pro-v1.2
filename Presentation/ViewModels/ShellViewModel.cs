using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MMS.Presentation.ViewModels
{
    public class ShellViewModel
    {
        // Primer property-ja za stavke menija
        public ObservableCollection<string> MenuItems { get; }

        // Primer property-ja za trenutno selektovanu stranicu
        public string? SelectedPage { get; set; }

        // Primer komande za navigaciju
        public ICommand? NavigateCommand { get; }

        // Konstruktor: inicijalizacija property-ja
        public ShellViewModel()
        {
            MenuItems = new ObservableCollection<string>
            {
                "Klijenti",
                "Objekti",
                "Komore",
                "Ugovori",
                "Radni nalozi",
                "Kalendar",
                "Oprema",
                "Fakturisanje",
                "Uplate",
                "Rashodi",
                "Izveštaji",
                "Administracija"
            };

            // Inicijalizacija komande (placeholder, implementiraj po potrebi)
            NavigateCommand = null;
        }
    }
}