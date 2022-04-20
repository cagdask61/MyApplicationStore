using MyApplicationStore.Application.Repositories.CategoryRepositories;
using MyApplicationStore.Domain.Entitites.Concrete;
using MyApplicationStore.Persistence.Contexts;
using MyApplicationStore.Persistence.Repositories.Base;

namespace MyApplicationStore.Persistence.Repositories.CategoryRepositories
{
    public class CategoryWriteRepository : EntityWriteRepositoryBase<Category>, ICategoryWriteRepository
    {
        public CategoryWriteRepository(MyApplicationStoreDbContext context) : base(context)
        {
        }
    }
}
