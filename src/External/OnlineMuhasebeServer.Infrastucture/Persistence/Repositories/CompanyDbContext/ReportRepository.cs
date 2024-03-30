using OnlineMuhasebeServer.Domain.CompanyEntites;
using OnlineMuhasebeServer.Domain.Repositories.CompanyDbContext;
using OnlineMuhasebeServer.Infrastucture.Persistence.Repositories.GenericRepositories.CompanyDbContext;

namespace OnlineMuhasebeServer.Infrastucture.Persistence.Repositories.CompanyDbContext;
public class ReportRepository: CompanyDbRepository<Report>, IReportRepository
{
}
