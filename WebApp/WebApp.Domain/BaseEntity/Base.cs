
namespace WebApp.Domain.BaseEntity
{
    public abstract class Base
    {
        public int Id { get; set; }

        public Guid Guid { get; set; }

        public required DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
    
    
}
