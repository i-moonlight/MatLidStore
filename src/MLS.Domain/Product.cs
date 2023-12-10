using MLS.Domain.Common;

namespace MLS.Domain;

public class Product : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string SKU { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    // Các thuộc tính khác

    public virtual Category Category { get; set; }
    public virtual ICollection<ProductImage> Images { get; set; }
    public virtual ICollection<OrderItem> OrderItems { get; set; }
    public virtual ICollection<ProductSupplier> ProductSuppliers { get; set; }
    public virtual ICollection<Review> Reviews { get; set; }
}