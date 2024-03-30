using OnlineMuhasebeServer.Domain.UnitOfWorks;
using OnlineMuhasebeServer.Infrastucture.Persistence.Context;

namespace OnlineMuhasebeServer.Infrastucture.Persistence.UnitOfWorks;

public sealed class ApplicationDbUnitOfWork : IApplicationDbUnitOfWork
{
    private readonly ApplicationDbContext _context;

    public ApplicationDbUnitOfWork(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        int count = await _context.SaveChangesAsync(cancellationToken);
        return count;
    }
}