using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;
using OnlineMuhasebeServer.Domain.Repositories.ApplicationDbContext;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.AppUserCompanyFeatures.Commands.RemoveByIdAppUserCompany;

public sealed class RemoveByIdAppUserCompanyCommandHandler(IAppUserCompanyAssociationRepository repository) : ICommandHandler<RemoveByIdAppUserCompanyCommand, MessageResponse>
{
    public async Task<MessageResponse> Handle(RemoveByIdAppUserCompanyCommand request, CancellationToken cancellationToken)
    {
        await repository.DeleteByIdAsync(request.Id.ToString());
        return new("Kullanıcı şirketten başarıyla çıkartıldı!");
    }
}
