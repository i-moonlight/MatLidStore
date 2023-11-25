namespace MLS.Domain;

public class Address
{
    public int AddressId { get; set; }
    public int UserId { get; set; }
    public string Street { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    // Các thuộc tính khác

    public virtual User User { get; set; }
}