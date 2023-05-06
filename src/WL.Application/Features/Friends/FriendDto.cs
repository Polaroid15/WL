namespace WL.Application.Features.Friends;

public record FriendDto {
    public long UserId { get; set; }
    public string Name { get; set; }
    public string AvatarImageId { get; set; }
}