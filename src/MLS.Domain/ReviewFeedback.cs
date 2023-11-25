using MLS.Domain.Common;

namespace MLS.Domain;

public class ReviewFeedback : BaseEntity
{
    public int ReviewId { get; set; }
    public string Feedback { get; set; } = string.Empty;
    // Các thuộc tính khác

    public virtual Review Review { get; set; }
}