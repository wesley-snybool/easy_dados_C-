using EasyDados.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyDados.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<User>> GetAllUsers()
        {
            // Implemente a lógica para obter todos os usuários usando o repositório
            return await _userRepository.GetAllUsers();
        }
    }
}
