using WL.Application.Common.Interfaces;
using WL.Domain.Entities;

namespace WL.Infrastructure.Persistence.Repositories;

public class WishlistItemRepository : GenericRepository<WishlistItem>, IWishlistItemRepository
{

    public WishlistItemRepository(AppDbContext dbContext) : base(dbContext)
    { }
}