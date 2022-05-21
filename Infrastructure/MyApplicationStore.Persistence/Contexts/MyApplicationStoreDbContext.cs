using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyApplicationStore.Domain.Entitites.Base;
using MyApplicationStore.Domain.Entitites.Concrete;
using MyApplicationStore.Persistence.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationStore.Persistence.Contexts
{
    public class MyApplicationStoreDbContext : DbContext
    {
        public MyApplicationStoreDbContext(DbContextOptions<MyApplicationStoreDbContext> options):base(options)
        {
        }
        protected MyApplicationStoreDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<App> Apps { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Category> Categories { get; set; }


        public override int SaveChanges()
        {
            var datas = ChangeTracker.Entries<Entity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.Now,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.Now,
                    _ => DateTime.Now
                };
            }
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<Entity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.Now,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.Now,
                    _ => DateTime.Now
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionStringConfiguration.Configure());
            }
        }

    }
}
