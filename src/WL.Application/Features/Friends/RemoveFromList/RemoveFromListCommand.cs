using MediatR;

namespace WL.Application.Features.Friends.RemoveFromList; 

public record RemoveFromListCommand(Guid FriendListId, long UserId) : IRequest<bool>;

public class RemoveFromListHandler : IRequestHandler<RemoveFromListCommand, bool> {

    public async Task<bool> Handle(RemoveFromListCommand request, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }
}