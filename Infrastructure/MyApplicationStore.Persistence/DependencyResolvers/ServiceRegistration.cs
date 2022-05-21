using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyApplicationStore.Application.Repositories.AppRepositories;
using MyApplicationStore.Application.Repositories.CategoryRepositories;
using MyApplicationStore.Application.Repositories.DeveloperRepositories;
using MyApplicationStore.Application.Repositories.UserRepositories;
using MyApplicationStore.Persistence.Configurations;
using MyApplicationStore.Persistence.Contexts;
using MyApplicationStore.Persistence.Repositories.AppRepositories;
using MyApplicationStore.Persistence.Repositories.CategoryRepositories;
using MyApplicationStore.Persistence.Repositories.DeveloperRepositories;
using MyApplicationStore.Persistence.Repositories.UserRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationStore.Persistence.DependencyResolvers
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {            
            services.AddScoped<IAppReadRepository,AppReadRepository>();
            services.AddScoped<IAppWriteRepository, AppWriteRepository>();

            services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();

            services.AddScoped<IUserReadRepository, UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();

            services.AddScoped<IDeveloperReadRepository, DeveloperReadRepository>();
            services.AddScoped<IDeveloperWriteRepository, DeveloperWriteRepository>();
        }
    }
}
