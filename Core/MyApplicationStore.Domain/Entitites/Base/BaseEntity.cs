using MyApplicationStore.Domain.Entitites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationStore.Domain.Entitites.Base
{
    //public class BaseEntity : IEntity
    //{
    //    public TKey Id { get; set; }
    //}

    public class BaseEntity : IEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }

}
