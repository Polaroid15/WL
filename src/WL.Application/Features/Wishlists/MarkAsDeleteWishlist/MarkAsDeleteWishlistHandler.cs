using MediatR;
using Microsoft.EntityFrameworkCore;
using WL.Application.Common.Exceptions;
using WL.Application.Common.Interfaces;

namespace WL.Application.Features.Wishlists.MarkAsDeleteWishlist;

public class MarkAsDeleteWishlistHandler : IRequestHandler<MarkAsDeleteWishlistCommand> {
    private readonly IApplicationDbContext _context;
    public MarkAsDeleteWishlistHandler(IApplicationDbContext context) => _context = context;

    public async Task Handle(MarkAsDeleteWishlistCommand request, CancellationToken cancellationToken) {
        var entity = await _context.Wishlists
            .Where(l => l.Id == request.Id)
            .SingleOrDefaultAsync(cancellationToken);

        if (entity == null) {
            throw new NotFoundException(nameof(Domain.Entities.Wishlist), request.Id);
        }

        _context.Wishlists.Remove(entity);

        await _context.SaveChangesAsync(cancellationToken);
    }
}

public record MarkAsDeleteWishlistCommand(long Id) : IRequest;