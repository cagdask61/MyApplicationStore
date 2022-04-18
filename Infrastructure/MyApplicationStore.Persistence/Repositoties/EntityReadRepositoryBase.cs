using Microsoft.EntityFrameworkCore;
using MyApplicationStore.Application.Repositories;
using MyApplicationStore.Domain.Entitites.Abstract;
using MyApplicationStore.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationStore.Persistence.Repositoties
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

        public Entity GetSingle(Expression<Func<Entity, bool>> filter)
        {
            return Table.SingleOrDefault(filter);
        }
        public Entity GetFirst(Expression<Func<Entity, bool>> filter)
        {
            return Table.FirstOrDefault(filter);
        }


        public async Task<Entity> GetSingleAsync(Expression<Func<Entity, bool>> filter)
        {
            return await Table.SingleOrDefaultAsync(filter);
        }
        

        public async Task<Entity> GetFirstAsync(Expression<Func<Entity, bool>> filter)
        {
            return await Table.FirstOrDefaultAsync(filter);
        }
    }
}
