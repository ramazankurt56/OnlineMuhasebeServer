using OnlineMuhasebeServer.Domain.Entities;
using OnlineMuhasebeServer.Domain.Repositories.ApplicationDbContext;
using OnlineMuhasebeServer.Infrastucture.Persistence.Repositories.GenericRepositories.ApplicationDbContext;

namespace OnlineMuhasebeServer.Infrastucture.Persistence.Repositories.ApplicationDbContext;
public class MainRoleRepository : ApplicationDbRepository<MainRole>, IMainRoleRepository
{
    public MainRoleRepository(Context.ApplicationDbContext context) : base(context)
    {
    }
}
