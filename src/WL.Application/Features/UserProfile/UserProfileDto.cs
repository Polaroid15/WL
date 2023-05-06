namespace WL.Application.Features.UserProfile;

public record UserProfileDto {
    public long UserId { get; set; }
    public string Name { get; set; }
    public string AvatarImageId { get; set; }
}