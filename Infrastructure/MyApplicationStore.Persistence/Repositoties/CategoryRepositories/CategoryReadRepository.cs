using MyApplicationStore.Application.Repositories.Base;
using MyApplicationStore.Domain.Entitites.Concrete;
using MyApplicationStore.Persistence.Contexts;
using MyApplicationStore.Persistence.Repositoties.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationStore.Application.Repositories.CategoryRepositories
{
    public class CategoryReadRepository : EntityReadRepositoryBase<Category>, ICategoryReadRepository
    {
        public CategoryReadRepository(MyApplicationStoreDbContext context) : base(context)
        {
        }
    }
}
