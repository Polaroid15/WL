using MediatR;

namespace WL.Application.Features.UserProfile.GetById; 

public record GetUserProfileByIdQuery(long UserId) : IRequest<UserProfileDto>;

public class GetUserProfileByIdHandler : IRequestHandler<GetUserProfileByIdQuery, UserProfileDto> {

    public async Task<UserProfileDto> Handle(GetUserProfileByIdQuery request, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }
} 