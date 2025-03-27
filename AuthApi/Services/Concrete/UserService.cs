using Core.Model.Dto.Concrete.Request;
using Core.Model.Entity.Concrete;
using Core.Service.JWT.Abstrct;
using Repositories.Abstrct;
using Services.Abstrct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;

        public UserService(IUserRepository userRepository, ITokenService tokenService)
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllUsersAsync();
        }

        public async Task<string> LoginAsync(LoginRequest request)
        {
            var users = await _userRepository.GetAllUsersAsync();
            var user = users.FirstOrDefault(u => u.Email == request.Email && u.Password == request.Password);

            if (user == null)
                throw new UnauthorizedAccessException("Invalid credentials");

            return _tokenService.GenerateToken(user);
        }

        public async Task RegisterAsync(RegisterRequest request)
        {
            var user = new User
            {
                Name = request.Name,
                Email = request.Email,
                Password = request.Password, 
                Phone = request.Phone
            };

            await _userRepository.AddUserAsync(user);
        }
    }
}
