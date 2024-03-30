using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Domain;
using OnlineMuhasebeServer.Domain.Entities;
using OnlineMuhasebeServer.Infrastucture.Persistence.Context;

namespace OnlineMuhasebeServer.Infrastucture;
public sealed class ContextService : IContextService
{
    private readonly ApplicationDbContext _appContext;

    public ContextService(ApplicationDbContext appContext)
    {
        _appContext = appContext;
    }

    public DbContext CreateCompanyDbContextInstance(Company company)
    {
        return new CompanyDbContext(company);
    }

    public DbContext CreateDbContextInstance(Guid companyId)
    {
        Company company = _appContext.Set<Company>().Find(companyId);
        return new CompanyDbContext(company);
    }
}