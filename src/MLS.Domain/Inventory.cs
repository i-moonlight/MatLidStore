using MLS.Domain.Common;

namespace MLS.Domain;

public class Inventory : BaseEntity
{
    public int ProductId { get; set; }
    public int QuantityInStock { get; set; }
    // Các thuộc tính khác

    public virtual Product Product { get; set; }
}