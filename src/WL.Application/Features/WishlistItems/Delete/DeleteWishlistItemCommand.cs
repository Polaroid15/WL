using MediatR;

namespace WL.Application.Features.WishlistItems.Delete; 

public record DeleteWishlistItemCommand(long WishlistItemId) : IRequest;

public class DeleteWishlistItemHandler : IRequestHandler<DeleteWishlistItemCommand> {

    public async Task Handle(DeleteWishlistItemCommand request, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }
}