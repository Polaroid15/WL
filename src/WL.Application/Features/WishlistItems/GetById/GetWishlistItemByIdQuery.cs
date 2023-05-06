using MediatR;

namespace WL.Application.Features.WishlistItems.GetById; 

public record GetWishlistItemByIdQuery(long WishlistItemId) : IRequest<WishlistItemDto>;

public class GetWishlistItemByIdHandler : IRequestHandler<GetWishlistItemByIdQuery, WishlistItemDto> {

    public async Task<WishlistItemDto> Handle(GetWishlistItemByIdQuery request, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }
}

public record WishlistItemDto {
    public long WishlistItemId { get; set; }
    public long WishlistId { get; set; }
    public long OriginalWishlistId { get; set; }
    public long UserId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}