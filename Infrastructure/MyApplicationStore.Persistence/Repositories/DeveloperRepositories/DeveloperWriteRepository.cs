using MyApplicationStore.Application.Repositories.DeveloperRepositories;
using MyApplicationStore.Domain.Entitites.Concrete;
using MyApplicationStore.Persistence.Contexts;
using MyApplicationStore.Persistence.Repositories.Base;

namespace MyApplicationStore.Persistence.Repositories.DeveloperRepositories
{
    public class DeveloperWriteRepository : EntityWriteRepositoryBase<Developer>,IDeveloperWriteRepository
    {
        public DeveloperWriteRepository(MyApplicationStoreDbContext context) : base(context)
        {
        }
    }
}
