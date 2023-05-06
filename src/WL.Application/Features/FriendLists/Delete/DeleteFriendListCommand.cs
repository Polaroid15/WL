using MediatR;

namespace WL.Application.Features.FriendLists.Delete; 

public record DeleteFriendListCommand(Guid FriendListId) : IRequest;

public class DeleteFriendListHandler : IRequestHandler<DeleteFriendListCommand> {

    public async Task Handle(DeleteFriendListCommand request, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }
}