using MLS.Domain.Common;

namespace MLS.Domain;

public class Supplier : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string ContactPerson { get; set; } = string.Empty;

    public string ContactNumber { get; set; } = string.Empty;
    // Các thuộc tính khác
}