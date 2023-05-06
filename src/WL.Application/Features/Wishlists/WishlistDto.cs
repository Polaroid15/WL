using WL.Domain.Entities;

namespace WL.Application.Features.Wishlists;

public record WishlistDto() {
    public long WishlistId { get; set; }
    public long UserId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<WishlistItem> Items { get; set; }
};