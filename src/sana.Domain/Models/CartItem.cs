
namespace sana.Domain.Models
{
    public class CartItem : EntityBase
    {
        public Guid CartID { get; set; }
        public ShoppingCart ShoppingCart { get; set; }

        public Guid ProductID { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
    }
}
