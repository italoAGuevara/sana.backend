
namespace sana.Domain.Models
{
    public class OrderItem : EntityBase
    {
        public Guid OrderID { get; set; }
        public Order Order { get; set; }

        public Guid ProductID { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
