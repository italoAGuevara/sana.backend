
namespace sana.Domain.Models
{
    public class ShoppingCart : EntityBase
    {
        public string UserId { get; set; }
        public IdentityUser User { get; set; }

        public ICollection<CartItem> CartItems { get; set; }
    }
}
