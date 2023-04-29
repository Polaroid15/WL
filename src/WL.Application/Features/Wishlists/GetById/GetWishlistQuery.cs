using System.ComponentModel.DataAnnotations;
using MediatR;
using Microsoft.EntityFrameworkCore;
using WL.Application.Common.Interfaces;
using WL.Domain.Entities;

public class GetWishHandler : IRequestHandler<GetWishlistQuery, Wishlist>
{
    private readonly IApplicationDbContext _context;

    public GetWishHandler(IApplicationDbContext context) => _context = context;


    public async Task<Wishlist> Handle(GetWishlistQuery request, CancellationToken cancellationToken)
    {
        var entity = await _context.Wishlists
            .Where(l => l.Id == request.Id)
            .SingleOrDefaultAsync(cancellationToken);
        return entity;
    }
}

public class GetWishlistQuery : IRequest<Wishlist>
{
    [Required]
    public long Id { get; set; }
}