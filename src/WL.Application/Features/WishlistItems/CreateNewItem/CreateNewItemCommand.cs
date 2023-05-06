using MediatR;

namespace WL.Application.Features.WishlistItems.CreateNewItem;

public record CreateNewItemCommand : IRequest<long> {
    public long WishlistId { get; set; }
    public long Name { get; set; }
    public string Description { get; set; }
}

public class CreateNewItemHandler : IRequestHandler<CreateNewItemCommand, long> {

    public async Task<long> Handle(CreateNewItemCommand request, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }
}