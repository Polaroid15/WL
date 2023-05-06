using MediatR;

namespace WL.Application.Features.FriendLists.Create; 

public record CreateFriendListCommand(long UserId, string Name, string Description, bool IsPublic) : IRequest<Guid>;

public class CreateFriendListHandler : IRequestHandler<CreateFriendListCommand, Guid> {

    public async Task<Guid> Handle(CreateFriendListCommand request, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }
}