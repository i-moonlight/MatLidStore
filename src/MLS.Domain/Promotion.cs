namespace MLS.Domain;

public class Promotion
{
    public int PromotionId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
    // Các thuộc tính khác
}