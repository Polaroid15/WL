using MediatR;
using WL.Application.Common.Models;

namespace WL.Application.Features.FriendLists.GetFriendLists;

public record GetFriendListsQuery : IRequest<PaginatedList<FriendListDto>> {
    public int UserId { get; init; }
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
};

public class GetFriendListsHandler : IRequestHandler<GetFriendListsQuery, PaginatedList<FriendListDto>> {

    public async Task<PaginatedList<FriendListDto>> Handle(GetFriendListsQuery request, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }
}