using EasyDados.Models;

public interface IUserService
{
    Task<List<User>> GetAllUsers();
}
