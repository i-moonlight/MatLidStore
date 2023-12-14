using MLS.Domain.Common;

namespace MLS.Domain;

public class Employee : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public string Position { get; set; } = string.Empty;
    // Các thuộc tính khác
}