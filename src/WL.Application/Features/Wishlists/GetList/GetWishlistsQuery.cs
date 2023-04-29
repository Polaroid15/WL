using MediatR;
using WL.Application.Common.Interfaces;
using WL.Application.Common.Models;

namespace WL.Application.Features.Wishlists.GetList;

public class GetWishlistsQuery : IRequest<PaginatedList<Domain.Entities.Wishlist>>
{
    
}

public class GetWishlistsHandler : IRequestHandler<GetWishlistsQuery, PaginatedList<Domain.Entities.Wishlist>> {
    private readonly IApplicationDbContext _context;
    public GetWishlistsHandler(IApplicationDbContext context) => _context = context;

    public async Task<PaginatedList<Domain.Entities.Wishlist>> Handle(GetWishlistsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}