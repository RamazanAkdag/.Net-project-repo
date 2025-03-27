using Core.Model.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstrct;
using Repositories.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concrete
{
    public class UserRepository : IUserRepository
    {
        private readonly AuthApiDbContext _dbContext;

        public UserRepository(AuthApiDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }

        public async Task AddUserAsync(User user)
        {
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }
    }
}
