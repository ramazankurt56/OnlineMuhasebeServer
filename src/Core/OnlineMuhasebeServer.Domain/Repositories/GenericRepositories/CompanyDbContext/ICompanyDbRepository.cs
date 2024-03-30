using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Domain.Abstraction;

namespace OnlineMuhasebeServer.Domain.Repositories.GenericRepositories.CompanyDbContext;
public interface ICompanyDbRepository<T> : IRepository<T>
      where T : class
{
    void SetDbContextInstance(DbContext context);
}