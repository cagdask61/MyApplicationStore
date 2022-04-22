using MyApplicationStore.Domain.Entitites.Abstract;
using MyApplicationStore.Domain.Entitites.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationStore.Application.Repositories.Base
{
    public interface IEntityReadRepository<Entity> : IEntityRepository<Entity>
        where Entity : class, IEntity
    {
        IQueryable<Entity> GetAll(bool tracking = false);
        IQueryable<Entity> GetAll(Expression<Func<Entity, bool>> filter, bool tracking = false);

        Entity GetSingle(Expression<Func<Entity, bool>> filter, bool tracking = false);
        Entity GetFirst(Expression<Func<Entity, bool>> filter, bool tracking = false);

        Task<Entity> GetSingleAsync(Expression<Func<Entity, bool>> filter, bool tracking = false);
        Task<Entity> GetFirstAsync(Expression<Func<Entity, bool>> filter, bool tracking = false);


    }
}
