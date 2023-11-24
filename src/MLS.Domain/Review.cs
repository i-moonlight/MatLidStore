using MLS.Domain.Common;

namespace MLS.Domain;

public class Review : BaseEntity
{
    public int ProductId { get; set; }
    public int CustomerId { get; set; }
    public string Comment { get; set; } = string.Empty;
    public int Rating { get; set; }
    // Các thuộc tính khác

    public virtual Product Product { get; set; }
    public virtual Customer Customer { get; set; }
    public virtual ICollection<ReviewFeedback> ReviewFeedbacks { get; set; }
}