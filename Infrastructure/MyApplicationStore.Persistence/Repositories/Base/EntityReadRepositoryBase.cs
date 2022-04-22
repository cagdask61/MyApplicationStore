using Microsoft.EntityFrameworkCore;
using MyApplicationStore.Application.Repositories.Base;
using MyApplicationStore.Domain.Entitites.Abstract;
using MyApplicationStore.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationStore.Persistence.Repositories.Base
{
    public class EntityReadRepositoryBase<Entity> : IEntityReadRepository<Entity>
        where Entity : class, IEntity
    {

        private readonly MyApplicationStoreDbContext _context;
        public EntityReadRepositoryBase(MyApplicationStoreDbContext context)
        {
            _context = context;
        }

        public DbSet<Entity> Table => _context.Set<Entity>();


        public IQueryable<Entity> GetAll(bool tracking = false)
        {
            var query = Table.AsQueryable();
            if (tracking == false)
            {
                query = query.AsNoTracking();
            }
            return query;
        }

        public IQueryable<Entity> GetAll(Expression<Func<Entity, bool>> filter, bool tracking = false)
        {
            var query = Table.Where(filter);
            if (tracking == false)
            {
                query = query.AsNoTracking();
            }
            return query;
        }


        public Entity GetFirst(Expression<Func<Entity, bool>> filter, bool tracking = false)
        {
            var query = Table.AsQueryable();
            if (tracking == false)
            {
                query = query.AsNoTracking();
            }
            return query.FirstOrDefault(filter);
        }
        public Entity GetSingle(Expression<Func<Entity, bool>> filter, bool tracking = false)
        {
            var query = Table.AsQueryable();
            if (tracking == false)
            {
                query = query.AsNoTracking();
            }
            return query.SingleOrDefault(filter);
        }


        public async Task<Entity> GetFirstAsync(Expression<Func<Entity, bool>> filter, bool tracking = false)
        {
            var query = Table.AsQueryable();
            if (tracking == false)
            {
                query = query.AsNoTracking();
            }
            return await query.FirstOrDefaultAsync(filter);
        }

        public async Task<Entity> GetSingleAsync(Expression<Func<Entity, bool>> filter, bool tracking = false)
        {
            var query = Table.AsQueryable();
            if (tracking == false)
            {
                query = query.AsNoTracking();
            }
            return await query.SingleOrDefaultAsync(filter);
        }



    }
}
