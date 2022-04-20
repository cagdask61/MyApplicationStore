using MyApplicationStore.Application.Repositories.UserRepositories;
using MyApplicationStore.Domain.Entitites.Concrete;
using MyApplicationStore.Persistence.Contexts;
using MyApplicationStore.Persistence.Repositories.Base;

namespace MyApplicationStore.Persistence.Repositories.UserRepositories
{
    public class UserWriteRepository : EntityWriteRepositoryBase<User>, IUserWriteRepository
    {
        public UserWriteRepository(MyApplicationStoreDbContext context) : base(context)
        {
        }
    }
}
