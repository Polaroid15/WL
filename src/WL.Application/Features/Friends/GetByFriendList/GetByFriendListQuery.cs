using MediatR;
using WL.Application.Common.Models;

namespace WL.Application.Features.Friends.GetByFriendList; 

public record GetByFriendListQuery : IRequest<PaginatedList<FriendDto>> {
    public int FriendListId { get; init; }
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
}

public class GetByFriendListHandler : IRequestHandler<GetByFriendListQuery, PaginatedList<FriendDto>> {

    public async Task<PaginatedList<FriendDto>> Handle(GetByFriendListQuery request, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }
}