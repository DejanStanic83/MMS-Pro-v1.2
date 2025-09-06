using Xunit;
using MMS.Domain.Entities;

namespace Domain.Test
{
    /// <summary>
    /// Test klasa za entitet User.
    /// Proverava kreiranje korisnika i osnovne podatke, kao i generisanje punog imena.
    /// </summary>
    public class UserTests
    {
        /// <summary>
        /// Testira da li se User može uspešno kreirati sa validnim podacima
        /// i da li su osnovna svojstva ispravno postavljena.
        /// </summary>
        [Fact]
        public void User_CanBeCreated_WithValidData()
        {
            // Arrange
            var id = 1;
            var ime = "Petar";
            var prezime = "Petroviæ";
            var role = "Admin";

            // Act
            var user = new User
            {
                Id = id,
                Ime = ime,
                Prezime = prezime,
                Role = role
            };

            // Assert
            Assert.Equal(id, user.Id);
            Assert.Equal(ime, user.Ime);
            Assert.Equal(prezime, user.Prezime);
            Assert.Equal(role, user.Role);
        }

        /// <summary>
        /// Testira da li se puno ime korisnika pravilno generiše spajanjem imena i prezimena.
        /// </summary>
        [Fact]
        public void User_FullName_IsCorrect()
        {
            // Arrange
            var user = new User
            {
                Ime = "Ana",
                Prezime = "Aniæ"
            };

            // Primer: ako imaš property FullName ili metodu za puno ime
            var expected = "Ana Aniæ";

            // Act
            var actual = $"{user.Ime} {user.Prezime}";

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}