using MyApplicationStore.Application.Repositories.Base;
using MyApplicationStore.Domain.Entitites.Concrete;
using MyApplicationStore.Persistence.Contexts;
using MyApplicationStore.Persistence.Repositoties.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationStore.Application.Repositories.AppRepositories
{
    public class AppWriteRepository : EntityWriteRepositoryBase<App>, IAppWriteRepository
    {
        public AppWriteRepository(MyApplicationStoreDbContext context) : base(context)
        {
        }
    }
}
