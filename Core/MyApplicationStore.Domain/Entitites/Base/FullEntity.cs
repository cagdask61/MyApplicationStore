using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationStore.Domain.Entitites.Base
{
    public class FullEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsApproved { get; set; }
    }
}
