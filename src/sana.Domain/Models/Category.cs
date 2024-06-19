
namespace sana.Domain.Models
{
    public class Category : EntityBase
    {
        public string CategoryName { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
