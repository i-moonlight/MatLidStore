using MLS.Domain.Common;

namespace MLS.Domain;

public class User : BaseEntity
{
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    // Các thuộc tính khác

    public virtual ICollection<Address> Addresses { get; set; }
    public virtual ICollection<WishList> WishLists { get; set; }
}