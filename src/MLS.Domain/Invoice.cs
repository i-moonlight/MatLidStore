using MLS.Domain.Common;

namespace MLS.Domain;

public class Invoice : BaseEntity
{
    public int OrderId { get; set; }
    public DateTime IssuedDate { get; set; }
    public decimal Amount { get; set; }
    // Các thuộc tính khác

    public virtual Order Order { get; set; }
}