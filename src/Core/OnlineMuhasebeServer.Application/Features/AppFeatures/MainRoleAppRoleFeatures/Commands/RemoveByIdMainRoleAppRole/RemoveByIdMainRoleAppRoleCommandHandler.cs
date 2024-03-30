using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;
using OnlineMuhasebeServer.Domain.Repositories.ApplicationDbContext;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleAppRoleFeatures.Commands.RemoveByIdMainRoleAppRole;

public sealed class RemoveByIdMainRoleAppRoleCommandHandler(IMainRoleAppRoleAssociationRepository repository) : ICommandHandler<RemoveByIdMainRoleAppRoleCommand, MessageResponse>
{
    public async Task<MessageResponse> Handle(RemoveByIdMainRoleAppRoleCommand request, CancellationToken cancellationToken)
    {

        var entity = await repository.GetByExpressionAsync(p => p.Id == request.Id);

        if (entity == null) throw new Exception("Belirtilen Ana Rol ve Rol bağlantısı bulunamadı!");

        await repository.DeleteByIdAsync(request.Id.ToString());
        return new("Role ve Ana Rol bağlantısı koparıldı");
    }
}
