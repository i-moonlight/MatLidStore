using MLS.Domain.Common;

namespace MLS.Domain;

public class Coupon : BaseEntity
{
    public string Code { get; set; } = string.Empty;
    public decimal DiscountAmount { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public bool IsActive { get; set; }
    // Các thuộc tính khác
}