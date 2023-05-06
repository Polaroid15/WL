using MediatR;
using WL.Application.Common.Interfaces;
using WL.Application.Common.Models;
using WL.Domain.Entities;

namespace WL.Application.Features.Wishlists.GetList;

public class GetWishlistsQuery : IRequest<PaginatedList<Wishlist>> {
    public int UserId { get; init; }
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
}

public class GetWishlistsHandler : IRequestHandler<GetWishlistsQuery, PaginatedList<Wishlist>> {
    private readonly IApplicationDbContext _context;
    public GetWishlistsHandler(IApplicationDbContext context) => _context = context;

    public async Task<PaginatedList<Wishlist>> Handle(GetWishlistsQuery request, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }
}