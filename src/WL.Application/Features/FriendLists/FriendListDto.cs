namespace WL.Application.Features.FriendLists;

public record FriendListDto {
    public Guid FriendListId { get; set; }
    public long UserId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsPublic { get; set; }
}