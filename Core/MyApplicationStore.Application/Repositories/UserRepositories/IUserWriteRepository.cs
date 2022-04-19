using MyApplicationStore.Application.Repositories.Base;
using MyApplicationStore.Domain.Entitites.Concrete;

namespace MyApplicationStore.Application.Repositories.UserRepositories
{
    public interface IUserWriteRepository : IEntityWriteRepository<User>
    {
    }
}
