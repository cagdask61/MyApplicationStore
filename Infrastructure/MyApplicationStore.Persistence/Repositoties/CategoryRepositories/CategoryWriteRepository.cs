using MyApplicationStore.Application.Repositories.Base;
using MyApplicationStore.Domain.Entitites.Concrete;
using MyApplicationStore.Persistence.Contexts;
using MyApplicationStore.Persistence.Repositoties.Base;

namespace MyApplicationStore.Application.Repositories.CategoryRepositories
{
    public class CategoryWriteRepository : EntityWriteRepositoryBase<Category>, ICategoryWriteRepository
    {
        public CategoryWriteRepository(MyApplicationStoreDbContext context) : base(context)
        {
        }
    }
}
