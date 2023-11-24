namespace MLS.Domain;

public class ShoppingCart
{
    public int ShoppingCartId { get; set; }
    public int CustomerId { get; set; }
    // Các thuộc tính khác

    public virtual Customer Customer { get; set; }
    public virtual ICollection<CartItem> CartItems { get; set; }
}