﻿using MLS.Domain.Common;

namespace MLS.Domain;

public class Return : BaseEntity
{
    public int OrderId { get; set; }
    public DateTime ReturnDate { get; set; }
    public string Reason { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    // Các thuộc tính khác

    public virtual Order Order { get; set; }
}