using MLS.Domain.Common;

namespace MLS.Domain;

public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    // Các thuộc tính khác

    public virtual ICollection<Product> Products { get; set; }
}