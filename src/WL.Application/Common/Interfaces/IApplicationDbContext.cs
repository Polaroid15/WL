using Microsoft.EntityFrameworkCore;
using WL.Domain.Entities;

namespace WL.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Domain.Entities.Wishlist> Wishlists { get; }
    DbSet<WishlistItem> WishlistItems { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}