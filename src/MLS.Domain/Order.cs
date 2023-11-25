using MLS.Domain.Common;

namespace MLS.Domain;

public class Order : BaseEntity
{
    public DateTime OrderDate { get; set; }
    public int CustomerId { get; set; }
    public decimal TotalAmount { get; set; }
    public string ShippingAddress { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    // Các thuộc tính khác

    public virtual ICollection<OrderItem> OrderItems { get; set; }
    public virtual Customer Customer { get; set; }
}