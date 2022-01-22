using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySecuredApp.MyUserDB
{
    public class DB:DbContext
    {
        public DB()
        {
        }

        public DB(DbContextOptions<DB> option):base(option)
        {
                
        }

        public DbSet<MyUser> MyUsers { get; set; }
    }
}
