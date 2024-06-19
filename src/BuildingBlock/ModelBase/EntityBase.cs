
namespace BuildingBlock.ModelBase
{
    public class EntityBase
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime TmStmp { get; set; } = DateTime.UtcNow;
    }
}
