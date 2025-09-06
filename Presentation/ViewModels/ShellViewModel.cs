using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MMS.Presentation.ViewModels
{
    /// <summary>
    /// ViewModel za glavnu (shell) stranicu aplikacije.
    /// Sadrži meni stavke i logiku za promenu stranica.
    /// </summary>
    public class ShellViewModel : INotifyPropertyChanged
    {
        // Privatno polje za trenutno izabranu stranicu
        private string? _selectedPage;

        /// <summary>
        /// Kolekcija stavki menija koje se prikazuju u glavnom meniju aplikacije.
        /// </summary>
        public ObservableCollection<string> MenuItems { get; }

        /// <summary>
        /// Trenutno izabrana stranica. Promena vrednosti obaveštava UI.
        /// </summary>
        public string? SelectedPage
        {
            get => _selectedPage;
            set
            {
                if (_selectedPage != value)
                {
                    _selectedPage = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Komanda za navigaciju između stranica (nije implementirana, može se dodati kasnije).
        /// </summary>
        public ICommand? NavigateCommand { get; }

        /// <summary>
        /// Konstruktor. Inicijalizuje kolekciju stavki menija i komandu za navigaciju.
        /// </summary>
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
                "Administracija",
                "Usluge"
            };

            NavigateCommand = null; // ovde možeš kasnije ubaciti RelayCommand ili sličnu implementaciju
        }

        /// <summary>
        /// Događaj koji se podiže kada se promeni vrednost nekog svojstva (INotifyPropertyChanged).
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Pomoćna metoda za podizanje PropertyChanged događaja.
        /// </summary>
        /// <param name="propertyName">Ime svojstva koje se promenilo.</param>
        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
