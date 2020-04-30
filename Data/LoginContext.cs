using LoginAndRegistration.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAndRegistration.Data
{
    public class LoginContext:DbContext
    {
        public LoginContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
