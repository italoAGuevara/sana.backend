
namespace sana.Domain.Models
{
    public class ProductCategory : EntityBase
    {
        public Guid ProductID { get; set; }
        public Product Product { get; set; }

        public Guid CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
