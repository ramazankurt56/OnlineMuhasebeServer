using OnlineMuhasebeServer.Domain.Entities;
using OnlineMuhasebeServer.Domain.Repositories.GenericRepositories.ApplicationDbContext;

namespace OnlineMuhasebeServer.Domain.Repositories.ApplicationDbContext;
public interface ICompanyRepository : IApplicationDbRepository<Company>
{
}
