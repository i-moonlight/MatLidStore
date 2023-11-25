namespace MLS.Domain;

public class Inventory
{
    public int InventoryId { get; set; }
    public int ProductId { get; set; }
    public int QuantityInStock { get; set; }
    // Các thuộc tính khác

    public virtual Product Product { get; set; }
}