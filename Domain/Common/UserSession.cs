namespace Domain.Common
{
    /// <summary>
    /// Interfejs koji defini�e podatke i operacije za korisni�ku sesiju.
    /// Omogu�ava pristup informacijama o trenutno prijavljenom korisniku.
    /// </summary>
    public interface IUserSession
    {
        /// <summary>
        /// ID trenutno prijavljenog korisnika (ili null ako nije prijavljen).
        /// </summary>
        int? UserId { get; }

        /// <summary>
        /// Korisni�ko ime trenutno prijavljenog korisnika.
        /// </summary>
        string? UserName { get; }

        /// <summary>
        /// Prikazno ime trenutno prijavljenog korisnika.
        /// </summary>
        string? DisplayName { get; }

        /// <summary>
        /// Uloga trenutno prijavljenog korisnika.
        /// </summary>
        string? Role { get; }

        /// <summary>
        /// Da li je korisnik autentifikovan (prijavljen).
        /// </summary>
        bool IsAuthenticated { get; }

        /// <summary>
        /// Postavlja podatke o korisniku u sesiju.
        /// </summary>
        /// <param name="userId">ID korisnika.</param>
        /// <param name="userName">Korisni�ko ime.</param>
        /// <param name="displayName">Prikazno ime.</param>
        /// <param name="role">Uloga korisnika.</param>
        void SetUser(int userId, string userName, string displayName, string role);

        /// <summary>
        /// Resetuje (bri�e) podatke o korisniku iz sesije.
        /// </summary>
        void Reset();
    }

    /// <summary>
    /// Implementacija korisni�ke sesije.
    /// �uva podatke o trenutno prijavljenom korisniku i omogu�ava njihovo postavljanje i resetovanje.
    /// </summary>
    public class UserSession : IUserSession
    {
        /// <inheritdoc/>
        public int? UserId { get; private set; }

        /// <inheritdoc/>
        public string? UserName { get; private set; }

        /// <inheritdoc/>
        public string? DisplayName { get; private set; }

        /// <inheritdoc/>
        public string? Role { get; private set; }

        /// <inheritdoc/>
        public bool IsAuthenticated => UserId.HasValue;

        /// <inheritdoc/>
        public void SetUser(int userId, string userName, string displayName, string role)
        {
            UserId = userId;
            UserName = userName;
            DisplayName = displayName;
            Role = role;
        }

        /// <inheritdoc/>
        public void Reset()
        {
            UserId = null;
            UserName = null;
            DisplayName = null;
            Role = null;
        }
    }
}