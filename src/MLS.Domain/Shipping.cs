using MLS.Domain.Common;

namespace MLS.Domain;

public class Shipping : BaseEntity
{
    public int OrderId { get; set; }
    public string ShippingStatus { get; set; } = string.Empty;
    public DateTime ShippedDate { get; set; }
    public string TrackingNumber { get; set; } = string.Empty;
    // Các thuộc tính khác

    public virtual Order Order { get; set; }
}