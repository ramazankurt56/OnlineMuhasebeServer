using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Domain.UnitOfWorks;
using OnlineMuhasebeServer.Infrastucture.Persistence.Context;

namespace OnlineMuhasebeServer.Infrastucture.Persistence.UnitOfWorks;
public sealed class CompanyDbUnitOfWork : ICompanyDbUnitOfWork
{
    private CompanyDbContext _context;
    public void SetDbContextInstance(DbContext context)
    {
        _context = (CompanyDbContext)context;
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        int count = await _context.SaveChangesAsync(cancellationToken);
        return count;
    }
}