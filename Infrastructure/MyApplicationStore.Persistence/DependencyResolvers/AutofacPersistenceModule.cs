using Autofac;
using Microsoft.EntityFrameworkCore;
using MyApplicationStore.Application.Repositories.AppRepositories;
using MyApplicationStore.Application.Repositories.CategoryRepositories;
using MyApplicationStore.Application.Repositories.DeveloperRepositories;
using MyApplicationStore.Application.Repositories.UserRepositories;
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
    public class AutofacPersistenceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AppReadRepository>().As<IAppReadRepository>().InstancePerLifetimeScope();
            builder.RegisterType<AppWriteRepository>().As<IAppWriteRepository>().InstancePerLifetimeScope();

            builder.RegisterType<CategoryReadRepository>().As<ICategoryReadRepository>().InstancePerLifetimeScope();
            builder.RegisterType<CategoryWriteRepository>().As<ICategoryWriteRepository>().InstancePerLifetimeScope();

            builder.RegisterType<UserReadRepository>().As<IUserReadRepository>().InstancePerLifetimeScope();
            builder.RegisterType<UserWriteRepository>().As<IUserWriteRepository>().InstancePerLifetimeScope();

            builder.RegisterType<DeveloperReadRepository>().As<IDeveloperReadRepository>().InstancePerLifetimeScope();
            builder.RegisterType<DeveloperWriteRepository>().As<IDeveloperWriteRepository>().InstancePerLifetimeScope();

        }
    }
}
