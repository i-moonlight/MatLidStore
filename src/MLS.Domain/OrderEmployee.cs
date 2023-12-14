using MLS.Domain.Common;

namespace MLS.Domain;

public class OrderEmployee : BaseEntity
{
    public int OrderId { get; set; }
    public int EmployeeId { get; set; }
    // Các thuộc tính khác

    public virtual Order Order { get; set; }
    public virtual Employee Employee { get; set; }
}