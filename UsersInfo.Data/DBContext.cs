using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UsersInfo.Core;

namespace UsersInfo.Data
{
    public class DBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.\SQLEXPRESS;Database=UserDemoDB;Encrypt=False; Trusted_Connection=true ");
        }
        public DbSet<User> Users { get; set; }
    }
}
