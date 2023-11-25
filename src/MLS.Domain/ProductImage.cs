using MLS.Domain.Common;

namespace MLS.Domain;

public class ProductImage : BaseEntity
{
    public int ProductId { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    // Các thuộc tính khác

    public virtual Product Product { get; set; }
}