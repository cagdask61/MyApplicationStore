using MyApplicationStore.Application.Repositories.AppRepositories;
using MyApplicationStore.Application.Repositories.CategoryRepositories;
using MyApplicationStore.Application.Repositories.DeveloperRepositories;
using MyApplicationStore.Application.Repositories.UserRepositories;
using MyApplicationStore.Persistence.Repositories.AppRepositories;
using MyApplicationStore.Persistence.Repositories.CategoryRepositories;
using MyApplicationStore.Persistence.Repositories.DeveloperRepositories;
using MyApplicationStore.Persistence.Repositories.UserRepositories;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationStore.Persistence.DependencyResolvers
{
    public class NinjectPersistenceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAppReadRepository>().To<AppReadRepository>().InSingletonScope();
            Bind<IAppWriteRepository>().To<AppWriteRepository>().InSingletonScope();

            Bind<ICategoryReadRepository>().To<CategoryReadRepository>().InSingletonScope();
            Bind<ICategoryWriteRepository>().To<CategoryWriteRepository>().InSingletonScope();

            Bind<IUserReadRepository>().To<UserReadRepository>().InSingletonScope();
            Bind<IUserReadRepository>().To<UserReadRepository>().InSingletonScope();

            Bind<IDeveloperReadRepository>().To<DeveloperReadRepository>().InSingletonScope();
            Bind<IDeveloperReadRepository>().To<DeveloperReadRepository>().InSingletonScope();
        }
    }
}
