using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineMuhasebeServer.Application.Abstraction;
using OnlineMuhasebeServer.Application.Services;
using OnlineMuhasebeServer.Domain;
using OnlineMuhasebeServer.Domain.Entities.Identity;
using OnlineMuhasebeServer.Domain.Repositories.ApplicationDbContext;
using OnlineMuhasebeServer.Domain.Repositories.CompanyDbContext;
using OnlineMuhasebeServer.Domain.UnitOfWorks;
using OnlineMuhasebeServer.Infrastucture.Authentication;
using OnlineMuhasebeServer.Infrastucture.Persistence.Context;
using OnlineMuhasebeServer.Infrastucture.Persistence.Repositories.ApplicationDbContext;
using OnlineMuhasebeServer.Infrastucture.Persistence.Repositories.CompanyDbContext;
using OnlineMuhasebeServer.Infrastucture.Persistence.UnitOfWorks;
using OnlineMuhasebeServer.Infrastucture.Services;

namespace OnlineMuhasebeServer.Infrastucture;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)

    {

        services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("SqlServer")));
        services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<ApplicationDbContext>();

        #region Jwt
        services.Configure<JwtOptions>(configuration.GetSection("Jwt"));
        services.ConfigureOptions<JwtTokenOptionsSetup>();
        services.AddAuthentication().AddBearerToken();
        services.AddScoped<IJwtProvider, JwtProvider>();
        #endregion


        #region Context UnitOfWork
        services.AddScoped<IApplicationDbUnitOfWork, ApplicationDbUnitOfWork>();
        services.AddScoped<ICompanyDbUnitOfWork, CompanyDbUnitOfWork>();
        services.AddScoped<IContextService, ContextService>();
        services.AddScoped<IApiService, ApiService>();
        #endregion

        #region Repositories
        services.AddScoped<ICompanyRepository, CompanyRepository>();
        services.AddScoped<IUCAFRepository, UCAFRepository>();
        services.AddScoped<IAppUserCompanyAssociationRepository, AppUserCompanyAssociarionRepository>();
        services.AddScoped<IMainRoleAppRoleAssociationRepository, MainRoleAppRoleAssociarionRepository>();
        services.AddScoped<IMainRoleAppUserAssociationRepository, MainRoleAppUserAssociarionRepository>();
        services.AddScoped<IMainRoleRepository, MainRoleRepository>();
        services.AddScoped<IBookEntryRepository, BookEntryRepository>();
        services.AddScoped<ILogRepository, LogRepository>();
        services.AddScoped<IReportRepository, ReportRepository>();
        #endregion
        
        
        //services.AddScoped<IUnitOfWork>(cfr => cfr.GetRequiredService<ApplicationDbContext>());
        return services;

    }
}
