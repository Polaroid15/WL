using MediatR;

namespace WL.Application.Features.FriendLists.GetById; 

public record GetFriendListByIdQuery(Guid FriendListId) : IRequest<FriendListDto>;

public class GetFriendListByIdHandler : IRequestHandler<GetFriendListByIdQuery, FriendListDto> {

    public async Task<FriendListDto> Handle(GetFriendListByIdQuery request, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }
}