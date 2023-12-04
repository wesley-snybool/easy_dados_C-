using EasyDados.Models;

public interface IUserRepository
{
    Task<List<User>> GetAllUsers();
    Task<User> GetUserByIdAsync(int id);
    Task<User> AddUserAsync(User user);
    Task<User> UpdateUserAsync(User user);
    Task<bool> DeleteUserAsync(int id);
}
