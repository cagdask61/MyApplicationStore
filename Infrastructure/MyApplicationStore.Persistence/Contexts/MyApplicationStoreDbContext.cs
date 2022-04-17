using Microsoft.EntityFrameworkCore;
using MyApplicationStore.Domain.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationStore.Persistence.Contexts
{
    public class MyApplicationStoreDbContext : DbContext
    {
        public MyApplicationStoreDbContext(DbContextOptions options):base(options)
        {
                
        }

        public DbSet<User> Users { get; set; }
        public DbSet<App> Apps { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
