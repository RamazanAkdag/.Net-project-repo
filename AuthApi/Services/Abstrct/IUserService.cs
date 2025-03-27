using Core.Model.Dto.Concrete.Request;
using Core.Model.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstrct
{
    public interface IUserService
    {
        Task RegisterAsync(RegisterRequest user);
        Task<List<User>> GetAllUsersAsync();
        Task<string> LoginAsync(LoginRequest request);

    }
}
