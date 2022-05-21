using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyApplicationStore.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationStore.Persistence.Configurations
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MyApplicationStoreDbContext>
    {      
        // refactor yapılacak
        public MyApplicationStoreDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<MyApplicationStoreDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(ConnectionStringConfiguration.Configure());
            return new MyApplicationStoreDbContext(dbContextOptionsBuilder.Options);
        }
    }
}
