using AutoMapper;
using MMS.Application.DTOs;
using MMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MMS.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly DbContext _dbContext;
        private readonly IMapper _mapper;

        public AuthService(DbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<UserDto?> AuthenticateAsync(string username, string password)
        {
            var user = await _dbContext.Set<User>()
                .FirstOrDefaultAsync(u => u.UserName == username && u.IsActive);

            if (user != null && /* provera lozinke */)
            {
                return _mapper.Map<UserDto>(user);
            }
            return null;
        }
    }
}