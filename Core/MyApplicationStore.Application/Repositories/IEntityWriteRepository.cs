using MyApplicationStore.Domain.Entitites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationStore.Application.Repositories
{
    public interface IEntityWriteRepository<Entity> : IEntityRepository<Entity>
        where Entity : class, IEntity
    {
        Task<bool> AddAsync(Entity entity);

        void Add(Entity entity);
        void Delete(Entity entity);
        void Update(Entity entity);

        int Save();
        Task<int> SaveAsync();
    }
}
