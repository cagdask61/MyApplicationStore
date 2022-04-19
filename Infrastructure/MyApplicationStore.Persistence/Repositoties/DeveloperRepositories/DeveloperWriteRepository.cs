using MyApplicationStore.Application.Repositories.Base;
using MyApplicationStore.Domain.Entitites.Concrete;
using MyApplicationStore.Persistence.Contexts;
using MyApplicationStore.Persistence.Repositoties.Base;

namespace MyApplicationStore.Application.Repositories.DeveloperRepositories
{
    public class DeveloperWriteRepository : EntityWriteRepositoryBase<Developer>,IDeveloperWriteRepository
    {
        public DeveloperWriteRepository(MyApplicationStoreDbContext context) : base(context)
        {
        }
    }
}
