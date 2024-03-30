using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;
using OnlineMuhasebeServer.Domain.Entities;
using OnlineMuhasebeServer.Domain.Repositories.ApplicationDbContext;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleAppUserFeatures.Commands.RemoveByIdMainRoleAppUser;

public sealed class RemoveByIdMainRoleAppUserCommandHandler(IMainRoleAppUserAssociationRepository repository) : ICommandHandler<RemoveByIdMainRoleAppUserCommand, MessageResponse>
{

    public async Task<MessageResponse> Handle(RemoveByIdMainRoleAppUserCommand request, CancellationToken cancellationToken)
    {
        MainRoleAppUserAssociation checkEntity = await repository.GetByExpressionAsync(p=>p.Id==request.Id);
        if (checkEntity == null) throw new Exception("Kullanıcı bu role zaten sahip değil!");

        await repository.DeleteByIdAsync(request.Id.ToString());

        return new("Kullanıcıdan rol yetkisi kaldırıldı");
    }
}
