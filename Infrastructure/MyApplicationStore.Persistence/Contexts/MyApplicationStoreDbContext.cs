using Microsoft.EntityFrameworkCore;
using MyApplicationStore.Domain.Entitites.Base;
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


        public override int SaveChanges()
        {
            var entities = base.ChangeTracker.Entries<Entity>();

            foreach (var item in entities)
            {
                switch (item.State)
                {
                    case EntityState.Added:
                        item.Entity.CreatedDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        item.Entity.UpdatedDate = DateTime.Now;
                        break;
                }
            }

            return base.SaveChanges();
        }

    }
}
