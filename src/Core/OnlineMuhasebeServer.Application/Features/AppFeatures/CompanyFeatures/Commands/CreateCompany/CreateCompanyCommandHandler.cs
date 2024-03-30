using AutoMapper;
using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;
using OnlineMuhasebeServer.Domain.Entities;
using OnlineMuhasebeServer.Domain.Repositories.ApplicationDbContext;
using OnlineMuhasebeServer.Domain.UnitOfWorks;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
public class CreateCompanyCommandHandler(ICompanyRepository companyRepository, IMapper mapper, IApplicationDbUnitOfWork unitOfWork) : ICommandHandler<CreateCompanyCommand, MessageResponse>
{
    public async Task<MessageResponse> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
    {
        Company getCompanyByName = companyRepository.GetByExpression(p => p.Name == request.Name);
        if (getCompanyByName is not null)
        {
            throw new Exception("Bu şirket adı daha önce kaydedilmiştir.");
        }
        Company company = mapper.Map<Company>(request);
        await companyRepository.AddAsync(company, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return new("Şirket kayfı başarıyla tamamlandı!");
    }
}
