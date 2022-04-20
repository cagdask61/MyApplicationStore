using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MyApplicationStore.Application.Repositories.Base;
using MyApplicationStore.Domain.Entitites.Abstract;
using MyApplicationStore.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationStore.Persistence.Repositories.Base
{
    public class EntityWriteRepositoryBase<Entity> : IEntityWriteRepository<Entity>
        where Entity : class, IEntity
    {
        private readonly MyApplicationStoreDbContext _context;
        public EntityWriteRepositoryBase(MyApplicationStoreDbContext context)
        {
            _context = context;
        }

        public DbSet<Entity> Table => _context.Set<Entity>();

        public void Add(Entity entity)
        {
            Table.Add(entity);
        }

        public async Task<bool> AddAsync(Entity entity)
        {
            EntityEntry entityAdd = await Table.AddAsync(entity);
            return entityAdd.State == EntityState.Added;
        }

        public void Delete(Entity entity)
        {
            Table.Remove(entity);
        }

        public int Save() => _context.SaveChanges();

        public async Task<int> SaveAsync() => await _context.SaveChangesAsync();

        public void Update(Entity entity)
        {
            Table.Update(entity);
        }

    }
}
