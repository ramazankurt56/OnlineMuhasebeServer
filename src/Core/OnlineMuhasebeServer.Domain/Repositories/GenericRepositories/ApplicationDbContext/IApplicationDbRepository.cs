using OnlineMuhasebeServer.Domain.Abstraction;

namespace OnlineMuhasebeServer.Domain.Repositories.GenericRepositories.ApplicationDbContext;
public interface IApplicationDbRepository<T>: IRepository<T>
    where T : class
{
}
