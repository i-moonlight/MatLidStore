using MLS.Domain.Common;

namespace MLS.Domain;

public class CartItem : BaseEntity
{
    public int ShoppingCartId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    // Các thuộc tính khác

    public virtual ShoppingCart ShoppingCart { get; set; }
    public virtual Product Product { get; set; }
}