﻿using OnlineMuhasebeServer.Domain.CompanyEntites;
using OnlineMuhasebeServer.Domain.Repositories.GenericRepositories.CompanyDbContext;

namespace OnlineMuhasebeServer.Domain.Repositories.CompanyDbContext;
public interface ILogRepository : ICompanyDbRepository<Log>
{
}
