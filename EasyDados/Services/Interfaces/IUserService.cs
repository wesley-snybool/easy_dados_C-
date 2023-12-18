using EasyDados.Models;

public interface IUserService
{
    Task<List<User>> GetAllUsers();
    Task<User> AddUser(User user);
}
