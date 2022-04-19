using MyApplicationStore.Application.Repositories.Base;
using MyApplicationStore.Domain.Entitites.Concrete;

namespace MyApplicationStore.Application.Repositories.DeveloperRepositories
{
    public interface IDeveloperWriteRepository : IEntityWriteRepository<Developer>
    {
    }
}
