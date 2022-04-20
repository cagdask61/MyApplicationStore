using MyApplicationStore.Application.Repositories.CategoryRepositories;
using MyApplicationStore.Domain.Entitites.Concrete;
using MyApplicationStore.Persistence.Contexts;
using MyApplicationStore.Persistence.Repositories.Base;

namespace MyApplicationStore.Persistence.Repositories.CategoryRepositories
{
    public class CategoryReadRepository : EntityReadRepositoryBase<Category>, ICategoryReadRepository
    {
        public CategoryReadRepository(MyApplicationStoreDbContext context) : base(context)
        {
        }
    }
}
