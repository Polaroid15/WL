using MediatR;

namespace WL.Application.Features.Wishlists.ShareToUser;

public record ShareToUserCommand(long UserId, long WishlistId) : IRequest<bool>;

public class ShareToUserHandler : IRequestHandler<ShareToUserCommand, bool> {
    
    public async Task<bool> Handle(ShareToUserCommand request, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }
}