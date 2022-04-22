using MyApplicationStore.Domain.Entitites.Abstract;
using MyApplicationStore.Domain.Entitites.Base;

namespace MyApplicationStore.Domain.Entitites.Concrete
{
    public class Developer : BaseEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public ICollection<App> Apps { get; set; }
        public User User { get; set; }
        public bool IsApproved { get; set; }
    }
}
