using MLS.Domain.Common;

namespace MLS.Domain;

public class Payment : BaseEntity
{
    public int OrderId { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public string PaymentMethod { get; set; } = string.Empty;
    // Các thuộc tính khác

    public virtual Order Order { get; set; }
}