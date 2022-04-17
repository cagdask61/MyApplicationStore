using MyApplicationStore.Domain.Entitites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationStore.Domain.Entitites.Concrete
{
    public class App : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int DeveloperId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsApproved { get; set; }

        public Category Category { get; set; }
        public Developer Developer { get; set; }

    }
}
