using MyApplicationStore.Domain.Entitites.Abstract;
using MyApplicationStore.Domain.Entitites.Base;

namespace MyApplicationStore.Domain.Entitites.Concrete
{
    public class Category : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsApproved { get; set; }
    }
}
