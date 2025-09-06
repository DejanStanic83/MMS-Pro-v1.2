using Domain.Common;

namespace MMS.Presentation.ViewModels
{
    /// <summary>
    /// ViewModel za glavni deo aplikacije (Main Window).
    /// Omoguæava pristup informacijama o trenutno prijavljenom korisniku i logout funkcionalnost.
    /// </summary>
    public class MainViewModel
    {
        // Referenca na servis za korisnièku sesiju
        private readonly IUserSession _userSession;

        /// <summary>
        /// Konstruktor koji prima servis za korisnièku sesiju.
        /// </summary>
        /// <param name="userSession">Servis za upravljanje korisnièkom sesijom.</param>
        public MainViewModel(IUserSession userSession)
        {
            _userSession = userSession;
        }

        /// <summary>
        /// Prikazno ime trenutno prijavljenog korisnika (za prikaz u UI).
        /// </summary>
        public string? DisplayName => _userSession.DisplayName;

        /// <summary>
        /// Uloga trenutno prijavljenog korisnika (za prikaz u UI).
        /// </summary>
        public string? Role => _userSession.Role;
        // Binduj na UI po potrebi

        /// <summary>
        /// Odjavljuje korisnika iz aplikacije i resetuje korisnièku sesiju.
        /// Dodaj dodatnu logiku za prebacivanje na login ekran ili èišæenje podataka po potrebi.
        /// </summary>
        public void Logout()
        {
            _userSession.Reset();
            // Dodaj logiku za prebacivanje na login ekran, èišæenje podataka, itd.
        }
    }
}