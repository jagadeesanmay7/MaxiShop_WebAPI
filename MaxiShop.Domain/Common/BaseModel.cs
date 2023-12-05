using System.ComponentModel.DataAnnotations;

namespace MaxiShop.Domain.Common
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;
    }
}
