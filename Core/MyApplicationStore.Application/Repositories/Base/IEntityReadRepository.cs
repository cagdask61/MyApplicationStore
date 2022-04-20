using MyApplicationStore.Domain.Entitites.Abstract;
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
        IQueryable<Entity> GetAll(Expression<Func<Entity,bool>>? filter = null);
        Entity GetSingle(Expression<Func<Entity, bool>> filter);
        Entity GetFirst(Expression<Func<Entity, bool>> filter);

        Task<Entity> GetSingleAsync(Expression<Func<Entity, bool>> filter);
        Task<Entity> GetFirstAsync(Expression<Func<Entity, bool>> filter);


        IQueryable<Entity> GetAllNoTracking(Expression<Func<Entity, bool>>? filter = null);
        Entity GetSingleNoTracking(Expression<Func<Entity, bool>> filter);
        Entity GetFirstNoTracking(Expression<Func<Entity, bool>> filter);

        Task<Entity> GetSingleAsyncNoTracking(Expression<Func<Entity, bool>> filter);
        Task<Entity> GetFirstAsyncNoTracking(Expression<Func<Entity, bool>> filter);
    }
}
