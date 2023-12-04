using EasyDados.Data;
using EasyDados.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyDados.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<User> AddUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUserAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public Task<User> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateUserAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}