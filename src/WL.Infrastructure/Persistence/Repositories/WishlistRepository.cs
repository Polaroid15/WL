using WL.Application.Common.Interfaces;
using WL.Domain.Entities;

namespace WL.Infrastructure.Persistence.Repositories;

public class WishlistRepository : GenericRepository<Wishlist>, IWishlistRepository
{

    public WishlistRepository(AppDbContext dbContext) : base(dbContext)
    { }
}