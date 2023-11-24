namespace MLS.Domain;

public class WishList
{
    public int WishListId { get; set; }
    public int CustomerId { get; set; }
    // Các thuộc tính khác

    public virtual Customer Customer { get; set; }
    public virtual ICollection<Product> Products { get; set; }
}