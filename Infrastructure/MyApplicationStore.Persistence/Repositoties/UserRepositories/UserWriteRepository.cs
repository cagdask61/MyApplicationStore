using MyApplicationStore.Application.Repositories.Base;
using MyApplicationStore.Domain.Entitites.Concrete;
using MyApplicationStore.Persistence.Contexts;
using MyApplicationStore.Persistence.Repositoties.Base;

namespace MyApplicationStore.Application.Repositories.UserRepositories
{
    public class UserWriteRepository : EntityWriteRepositoryBase<User>, IUserWriteRepository
    {
        public UserWriteRepository(MyApplicationStoreDbContext context) : base(context)
        {
        }
    }
}
