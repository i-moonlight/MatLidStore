using MLS.Domain.Common;

namespace MLS.Domain;

public class Promotion : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
    // Các thuộc tính khác
}