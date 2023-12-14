using MLS.Domain.Common;

namespace MLS.Domain;

public class ShoppingCart : BaseEntity
{
    public int CustomerId { get; set; }
    // Các thuộc tính khác

    public virtual Customer Customer { get; set; }
    public virtual ICollection<CartItem> CartItems { get; set; }
}