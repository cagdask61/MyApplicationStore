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

        public IQueryable<Entity> GetAll(Expression<Func<Entity, bool>>? filter = null)
        {
            return filter == null ? Table : Table.Where(filter);
        }       

        public Entity GetFirst(Expression<Func<Entity, bool>> filter)
        {
            return Table.FirstOrDefault(filter);
        }

        public async Task<Entity> GetFirstAsync(Expression<Func<Entity, bool>> filter)
        {
            return  await Table.FirstOrDefaultAsync(filter);
        }

        public Entity GetSingle(Expression<Func<Entity, bool>> filter)
        {
            return Table.SingleOrDefault(filter);
        }


        public async Task<Entity> GetSingleAsync(Expression<Func<Entity, bool>> filter)
        {
            return await Table.SingleOrDefaultAsync(filter);
        }

        // No Tracking 
        public IQueryable<Entity> GetAllNoTracking(Expression<Func<Entity, bool>>? filter = null)
        {
            var query = Table.AsQueryable();
            return filter == null ? query.AsNoTracking() : query.Where(filter).AsNoTracking();
        }

        public Entity GetSingleNoTracking(Expression<Func<Entity, bool>> filter)
        {
            return Table.AsQueryable().AsNoTracking().SingleOrDefault(filter);
        }

        public Entity GetFirstNoTracking(Expression<Func<Entity, bool>> filter)
        {
            return Table.AsQueryable().AsNoTracking().FirstOrDefault(filter);
        }               

        public async Task<Entity> GetSingleAsyncNoTracking(Expression<Func<Entity, bool>> filter)
        {
            return await Table.AsQueryable().AsNoTracking().SingleOrDefaultAsync(filter);
        }

        public async Task<Entity> GetFirstAsyncNoTracking(Expression<Func<Entity, bool>> filter)
        {
            return await Table.AsQueryable().AsNoTracking().FirstOrDefaultAsync(filter);
        }

        
    }
}
