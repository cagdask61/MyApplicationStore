using MyApplicationStore.Domain.Entitites.Abstract;
using MyApplicationStore.Domain.Entitites.Base;

namespace MyApplicationStore.Domain.Entitites.Concrete
{
    public class UserOperationClaim : BaseEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }

        public User User { get; set; }
        public OperationClaim OperationClaim { get; set; }
        public bool IsApproved { get; set; }
    }
}
