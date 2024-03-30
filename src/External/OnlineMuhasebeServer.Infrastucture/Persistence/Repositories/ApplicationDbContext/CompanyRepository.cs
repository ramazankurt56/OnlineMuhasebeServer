using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Domain.Entities;
using OnlineMuhasebeServer.Domain.Repositories.ApplicationDbContext;
using OnlineMuhasebeServer.Infrastucture.Persistence.Repositories.GenericRepositories.ApplicationDbContext;

namespace OnlineMuhasebeServer.Infrastucture.Persistence.Repositories.ApplicationDbContext;
internal class CompanyRepository : ApplicationDbRepository<Company>, ICompanyRepository
{
    public CompanyRepository(Context.ApplicationDbContext context) : base(context)
    {
    }
}
