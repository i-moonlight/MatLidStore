using MLS.Domain.Common;

namespace MLS.Domain;

public class OrderHistory : BaseEntity
{
    public int OrderId { get; set; }
    public string Status { get; set; } = string.Empty;
    public DateTime DateChanged { get; set; }
    // Các thuộc tính khác

    public virtual Order Order { get; set; }
}