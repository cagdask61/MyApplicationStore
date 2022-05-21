using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyApplicationStore.Persistence.Configurations;
using MyApplicationStore.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationStore.Persistence.DependencyResolvers
{
    public static class DbContextRegistration
    {
        public static void AddDbContexts(this IServiceCollection services)
        {
            services.AddDbContext<MyApplicationStoreDbContext>(options => options.UseSqlServer(ConnectionStringConfiguration.Configure()),ServiceLifetime.Scoped);

            //services.AddDbContext<MyApplicationStoreDbContext, MsSqlDbContext>(options => options.UseSqlServer(ConnectionStringConfiguration.Configure()));
        }
    }
}
