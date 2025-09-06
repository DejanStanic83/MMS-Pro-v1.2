using Xunit;
using Moq;
using MMS.Application.Services;
using MMS.Domain.Entities;
using MMS.Application.DTOs;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using MMS.Infrastructure.Data; // Dodaj ovu liniju umesto: using MMS.Infrastructure;
// If AppDbContext is in a different namespace, replace the above line with the correct one
// using YourAppNamespace.Data; 


namespace Application.Test
{
    public class AuthServiceTests
    {
        private static IMapper GetMapper()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<UserProfile>());
            return config.CreateMapper();
        }

        private static DbContext GetDbContextWithUsers(List<User> users)
        {
            var options = new DbContextOptionsBuilder<AppDbContext>() // Ispravi ovde tip!
                .UseInMemoryDatabase(databaseName: "TestDb_" + System.Guid.NewGuid())
                .Options;
            var dbContext = new AppDbContext(options);
            dbContext.Set<User>().AddRange(users);
            dbContext.SaveChanges();
            return dbContext;
        }

        [Fact]
        public async Task AuthenticateAsync_ReturnsUserDto_WhenCredentialsAreValid()
        {
            // Arrange
            var user = new User
            {
                Id = 1,
                UserName = "testuser",
                PasswordHash = "password",
                IsActive = true,
                Ime = "Test",
                Prezime = "User",
                Role = "Admin"
            };
            var dbContext = GetDbContextWithUsers(new List<User> { user });
            var mapper = GetMapper();
            var service = new AuthService(dbContext, mapper);

            // Act
            var result = await service.AuthenticateAsync("testuser", "password");

            // Assert
            Assert.NotNull(result);
            Assert.Equal(user.UserName, result.UserName);
            Assert.Equal("Test User", result.DisplayName);
            Assert.Equal("Admin", result.Role);
        }

        [Fact]
        public async Task AuthenticateAsync_ReturnsNull_WhenPasswordIsInvalid()
        {
            var user = new User
            {
                Id = 1,
                UserName = "testuser",
                PasswordHash = "password",
                IsActive = true
            };
            var dbContext = GetDbContextWithUsers(new List<User> { user });
            var mapper = GetMapper();
            var service = new AuthService(dbContext, mapper);

            var result = await service.AuthenticateAsync("testuser", "wrongpassword");

            Assert.Null(result);
        }

        [Fact]
        public async Task AuthenticateAsync_ReturnsNull_WhenUserIsInactive()
        {
            var user = new User
            {
                Id = 1,
                UserName = "inactiveuser",
                PasswordHash = "password",
                IsActive = false
            };
            var dbContext = GetDbContextWithUsers(new List<User> { user });
            var mapper = GetMapper();
            var service = new AuthService(dbContext, mapper);

            var result = await service.AuthenticateAsync("inactiveuser", "password");

            Assert.Null(result);
        }

        [Fact]
        public async Task AuthenticateAsync_ReturnsNull_WhenUserDoesNotExist()
        {
            var dbContext = GetDbContextWithUsers(new List<User>());
            var mapper = GetMapper();
            var service = new AuthService(dbContext, mapper);

            var result = await service.AuthenticateAsync("nosuchuser", "password");

            Assert.Null(result);
        }

        [Fact]
        public void UserProfile_Maps_DisplayName_And_Role_Correctly()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<UserProfile>());
            var mapper = config.CreateMapper();
            var user = new User
            {
                Ime = "Ana",
                Prezime = "Aniæ",
                Role = "Admin"
            };

            var dto = mapper.Map<UserDto>(user);

            Assert.Equal("Ana Aniæ", dto.DisplayName);
            Assert.Equal("Admin", dto.Role);
        }
    }
}