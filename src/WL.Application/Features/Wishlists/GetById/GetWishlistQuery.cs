using System.ComponentModel.DataAnnotations;
using MediatR;
using WL.Application.Common.Interfaces;
using WL.Domain.Entities;

public class GetWishHandler : IRequestHandler<GetWishlistQuery, Domain.Entities.Wishlist>
{
    private readonly WishlistItemRepository _wishlistRepository;

    public GetWishHandler(IWishlistItemRepository wishlistRepository)
    {
        _wishlistRepository = wishlistRepository;
    }


    public async Task<Wishlist> Handle(GetWishlistQuery request, CancellationToken cancellationToken)
    {
        // var entity = await _wishlistRepository.GetAsync<Domain.Entities.Wishlist>(x => x.Uid == request.Id);
        return new Wishlist();
    }
}

public class GetWishlistQuery : IRequest<Wishlist>
{
    [Required]
    public Guid Id { get; set; }
}