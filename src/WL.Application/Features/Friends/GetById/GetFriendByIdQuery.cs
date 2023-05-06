using MediatR;

namespace WL.Application.Features.Friends.GetById; 

public record GetFriendByIdQuery(Guid FriendListId, long UserId) : IRequest<FriendDto>;

public class GetFriendByIdHandler : IRequestHandler<GetFriendByIdQuery, FriendDto> {

    public async Task<FriendDto> Handle(GetFriendByIdQuery request, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }
}