using MediatR;

namespace WL.Application.Features.FriendLists.Update;

public record UpdateFriendListCommand : IRequest<Guid> {
    public Guid FriendListId { get; set; }
    public long UserId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsPublic { get; set; }
};