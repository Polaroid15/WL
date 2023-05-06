using MediatR;

namespace WL.Application.Features.WishlistItems.AssignToWishlistItem;

public record AssignToWishlistItemCommand(long UserId, Guid WishlistItem) : IRequest<bool>;

public class AssignToWishlistItemHandler : IRequestHandler<AssignToWishlistItemCommand, bool> {

    public async Task<bool> Handle(AssignToWishlistItemCommand request, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }
}