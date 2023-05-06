using MediatR;

namespace WL.Application.Features.Friends.Add; 

public record AddFriendCommand(Guid FriendListId, long UserId) : IRequest<bool>;

public class AddFriendHandler : IRequestHandler<AddFriendCommand, bool> {

    public async Task<bool> Handle(AddFriendCommand request, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }
}