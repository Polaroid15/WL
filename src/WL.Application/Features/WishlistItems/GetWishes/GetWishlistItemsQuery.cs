using MediatR;
using WL.Application.Common.Models;
using WL.Application.Features.WishlistItems.GetById;

namespace WL.Application.Features.WishlistItems.GetWishes;

public record GetWishlistItemsQuery : IRequest<PaginatedList<WishlistItemDto>> 
{
    public int WishlistId { get; init; }
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
}

public class GetWishlistItemsHandler : IRequestHandler<GetWishlistItemsQuery, PaginatedList<WishlistItemDto>> 
{

    public async Task<PaginatedList<WishlistItemDto>> Handle(GetWishlistItemsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}