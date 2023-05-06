using MediatR;

namespace WL.Application.Features.WishlistItems.Update;

public record UpdateWishlistItemCommand : IRequest<long> {
    public long WishlistItemId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
};

public class UpdateWishlistItemHandler : IRequestHandler<UpdateWishlistItemCommand, long> {

    public async Task<long> Handle(UpdateWishlistItemCommand request, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }
}