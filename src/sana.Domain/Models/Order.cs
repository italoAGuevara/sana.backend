
namespace sana.Domain.Models
{
    public class Order : EntityBase
    {
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        public decimal TotalAmount { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
