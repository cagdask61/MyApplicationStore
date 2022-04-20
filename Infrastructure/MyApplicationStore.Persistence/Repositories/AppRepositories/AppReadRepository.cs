using MyApplicationStore.Application.Repositories.AppRepositories;
using MyApplicationStore.Domain.Entitites.Concrete;
using MyApplicationStore.Persistence.Contexts;
using MyApplicationStore.Persistence.Repositories.Base;

namespace MyApplicationStore.Persistence.Repositories.AppRepositories
{
    public class AppReadRepository : EntityReadRepositoryBase<App>, IAppReadRepository
    {
        public AppReadRepository(MyApplicationStoreDbContext context) : base(context)
        {
        }
    }
}
