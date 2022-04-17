using MyApplicationStore.Domain.Entitites.Abstract;

namespace MyApplicationStore.Domain.Entitites.Concrete
{
    public class Developer : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public ICollection<App> Apps { get; set; }
        public User User { get; set; }
    }
}
