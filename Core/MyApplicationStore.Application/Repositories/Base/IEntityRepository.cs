using Microsoft.EntityFrameworkCore;
using MyApplicationStore.Domain.Entitites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationStore.Application.Repositories.Base
{
    public interface IEntityRepository<Entity>
        where Entity : class, IEntity
    {
        DbSet<Entity> Table { get; }
    }
}
