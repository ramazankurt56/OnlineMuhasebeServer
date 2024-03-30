using OnlineMuhasebeServer.Domain.Entities;
using OnlineMuhasebeServer.Domain.Repositories.ApplicationDbContext;
using OnlineMuhasebeServer.Infrastucture.Persistence.Repositories.GenericRepositories.ApplicationDbContext;

namespace OnlineMuhasebeServer.Infrastucture.Persistence.Repositories.ApplicationDbContext;
public class MainRoleAppRoleAssociarionRepository : ApplicationDbRepository<MainRoleAppRoleAssociation>, IMainRoleAppRoleAssociationRepository
{
    public MainRoleAppRoleAssociarionRepository(Context.ApplicationDbContext context) : base(context)
    {
    }
}
