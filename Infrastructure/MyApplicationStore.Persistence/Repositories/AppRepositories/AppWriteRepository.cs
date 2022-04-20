using MyApplicationStore.Application.Repositories.AppRepositories;
using MyApplicationStore.Domain.Entitites.Concrete;
using MyApplicationStore.Persistence.Contexts;
using MyApplicationStore.Persistence.Repositories.Base;

namespace MyApplicationStore.Persistence.Repositories.AppRepositories
{
    public class AppWriteRepository : EntityWriteRepositoryBase<App>, IAppWriteRepository
    {
        public AppWriteRepository(MyApplicationStoreDbContext context) : base(context)
        {
        }
    }
}
