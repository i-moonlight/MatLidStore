using MLS.Domain.Common;

namespace MLS.Domain;

public class OrderItem : BaseEntity
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    // Các thuộc tính khác

    public virtual Order Order { get; set; }
    public virtual Product Product { get; set; }
}