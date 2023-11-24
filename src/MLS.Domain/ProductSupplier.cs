using MLS.Domain.Common;

namespace MLS.Domain;

public class ProductSupplier : BaseEntity
{
    public int ProductId { get; set; }
    public int SupplierId { get; set; }
    public decimal Price { get; set; }
    // Các thuộc tính khác

    public virtual Product Product { get; set; }
    public virtual Supplier Supplier { get; set; }
}