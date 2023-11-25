using MLS.Domain.Common;

namespace MLS.Domain;

public class Delivery : BaseEntity
{
    public int OrderId { get; set; }
    public DateTime ShippedDate { get; set; }
    public DateTime DeliveryDate { get; set; }
    public string Status { get; set; } = string.Empty;
    // Các thuộc tính khác

    public virtual Order Order { get; set; }
}