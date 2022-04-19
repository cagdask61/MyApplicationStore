using MyApplicationStore.Application.Repositories.Base;
using MyApplicationStore.Domain.Entitites.Concrete;
using MyApplicationStore.Persistence.Contexts;
using MyApplicationStore.Persistence.Repositoties.Base;

namespace MyApplicationStore.Application.Repositories.AppRepositories
{
    public class AppReadRepository : EntityReadRepositoryBase<App>, IAppReadRepository
    {
        public AppReadRepository(MyApplicationStoreDbContext context) : base(context)
        {
        }
    }
}
