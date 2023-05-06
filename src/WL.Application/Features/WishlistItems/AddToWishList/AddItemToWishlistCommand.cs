using MediatR;

namespace WL.Application.Features.WishlistItems.AddToWishList;

public record AddItemToWishlistCommand : IRequest<long> {
    public long WishlistItemId { get; set; }
    public long WishlistId { get; set; }
    public long OriginalWishlistId { get; set; }
}

public class AddItemToWishlistHandler : IRequestHandler<AddItemToWishlistCommand, long> {

    public async Task<long> Handle(AddItemToWishlistCommand request, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }
}