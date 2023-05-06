using MediatR;
using Microsoft.EntityFrameworkCore;
using WL.Application.Common.Exceptions;
using WL.Application.Common.Interfaces;
using WL.Domain.Entities;

namespace WL.Application.Features.Wishlists.MarkAsDelete;

public record MarkAsDeleteWishlistCommand(long WishlistId) : IRequest;

public class MarkAsDeleteWishlistHandler : IRequestHandler<MarkAsDeleteWishlistCommand> {
    private readonly IApplicationDbContext _context;
    public MarkAsDeleteWishlistHandler(IApplicationDbContext context) => _context = context;

    public async Task Handle(MarkAsDeleteWishlistCommand request, CancellationToken cancellationToken) {
        var entity = await _context.Wishlists
            .Where(l => l.Id == request.WishlistId)
            .SingleOrDefaultAsync(cancellationToken);

        if (entity == null) {
            throw new NotFoundException(nameof(Wishlist), request.WishlistId);
        }

        _context.Wishlists.Remove(entity);

        await _context.SaveChangesAsync(cancellationToken);
    }
}