using MyApplicationStore.Application.Repositories.Base;
using MyApplicationStore.Domain.Entitites.Concrete;

namespace MyApplicationStore.Application.Repositories.CategoryRepositories
{
    public interface ICategoryWriteRepository : IEntityWriteRepository<Category>
    {
    }
}
