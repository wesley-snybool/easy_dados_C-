using EasyDados.Models;
using Microsoft.AspNetCore.Mvc;

namespace EasyDados.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILogger<UserController> _logger;
        public UserController(IUserService userRepository, ILogger<UserController> logger)
        {
            _userService = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

            _logger.LogInformation("UserController construído");
        }
        [HttpGet]
        public async Task<List<User>> FindAllUsers()
        {
            return await _userService.GetAllUsers();
        }
    }
}
