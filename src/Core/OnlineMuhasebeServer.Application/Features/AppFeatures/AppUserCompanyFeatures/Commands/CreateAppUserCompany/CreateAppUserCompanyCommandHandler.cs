using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;
using OnlineMuhasebeServer.Domain.Entities;
using OnlineMuhasebeServer.Domain.Repositories.ApplicationDbContext;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.AppUserCompanyFeatures.Commands.CreateAppUserCompany;


public sealed class CreateAppUserCompanyCommandHandler(IAppUserCompanyAssociationRepository repository) : ICommandHandler<CreateAppUserCompanyCommand, MessageResponse>
{
    public async Task<MessageResponse> Handle(CreateAppUserCompanyCommand request, CancellationToken cancellationToken)
    {
        AppUserCompanyAssociation entity = await repository.GetByExpressionAsync(p=>p.AppUserId==request.AppUserId && p.CompanyId== request.CompanyId, cancellationToken);
        if (entity != null) throw new Exception("Bu kullanıcı daha önce bu şirkete kayıt edilmiş!");

        AppUserCompanyAssociation userAndCompanyRelationship = new(
            request.AppUserId,
            request.CompanyId);

        await repository.AddAsync(userAndCompanyRelationship, cancellationToken);
        return new("Kullanıcı şirkete başarıyla kayıt edildi!");
    }
}

