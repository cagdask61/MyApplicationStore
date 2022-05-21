using Microsoft.EntityFrameworkCore;
using MyApplicationStore.Persistence.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationStore.Persistence.Contexts
{
    public sealed class MsSqlDbContext : MyApplicationStoreDbContext
    {
        public MsSqlDbContext(DbContextOptions<MyApplicationStoreDbContext> options) : base(options)
        {
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
