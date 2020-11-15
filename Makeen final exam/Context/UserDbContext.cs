using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Makeen_final_exam.Model;
using Microsoft.EntityFrameworkCore;

namespace Makeen_final_exam
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext>options) : base(options)
        {
            
        }

        private DbSet<User> users { get; set; }
    }
}
