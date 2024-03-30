using MediatR;
using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain;
using OnlineMuhasebeServer.Domain.Dtos;
using OnlineMuhasebeServer.Domain.Repositories.ApplicationDbContext;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabase;
public class MigrateCompanyDatabaseCommandHandler(ICompanyRepository companyRepository,IContextService contextService) :
    ICommandHandler<MigrateCompanyDatabaseCommand, MessageResponse>
{
    public async Task<MessageResponse> Handle(MigrateCompanyDatabaseCommand request, CancellationToken cancellationToken)
    {
        var companies = await companyRepository.GetAll().ToListAsync(cancellationToken);
        foreach (var company in companies)
        {
            var db = contextService.CreateDbContextInstance(company.Id);
            db.Database.Migrate();
        }
        return new("Şirketlerin database bilgileri Migrate Edildi");
    }
}
