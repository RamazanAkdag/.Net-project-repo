using Core.Model.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Config
{
    public class AuthApiDbContext : DbContext
    {

      public AuthApiDbContext(DbContextOptions options) : base(options)
        {
        }  

       public DbSet<User> Users { get; set; }
    }
}
