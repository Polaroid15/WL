using WL.Domain.Common;

namespace WL.Domain.Entities;

public class WishesCatalog : BaseAuditableEntity
{
    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public List<WishlistItem> Wishes { get; set; } = new();
    
    public override string ToString() => $"{Id}: {Title} - {Description}";
}