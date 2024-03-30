using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Domain.Entities;

namespace OnlineMuhasebeServer.Domain;
public interface IContextService
{
    DbContext CreateDbContextInstance(Guid companyId);
    DbContext CreateCompanyDbContextInstance(Company company);
}