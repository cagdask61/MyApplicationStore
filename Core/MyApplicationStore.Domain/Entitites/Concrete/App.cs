using MyApplicationStore.Domain.Entitites.Abstract;
using MyApplicationStore.Domain.Entitites.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationStore.Domain.Entitites.Concrete
{
    public class App : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int DeveloperId { get; set; }
        public bool IsApproved { get; set; }


        public Category Category { get; set; }
        public Developer Developer { get; set; }

    }
}
