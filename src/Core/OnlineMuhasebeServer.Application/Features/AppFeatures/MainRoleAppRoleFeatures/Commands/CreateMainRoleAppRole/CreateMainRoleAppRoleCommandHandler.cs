using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;
using OnlineMuhasebeServer.Domain.Entities;
using OnlineMuhasebeServer.Domain.Repositories.ApplicationDbContext;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleAppRoleFeatures.Commands.CreateMainRoleAppRole;

public sealed record CreateMainRoleAppRoleCommandHandler(IMainRoleAppRoleAssociationRepository repository) : ICommandHandler<CreateMainRoleAppRoleCommand, MessageResponse>
{


    public async Task<MessageResponse> Handle(CreateMainRoleAppRoleCommand request, CancellationToken cancellationToken)
    {
        var checkRoleAndMainRoleIsRelated = await repository.GetByExpressionAsync(p => p.RoleId == request.RoleId && p.MainRoleId == request.MainRoleId, cancellationToken);

        if (checkRoleAndMainRoleIsRelated != null) throw new Exception("Bu rol ilişlişi daha önce kurulmuş!");

        MainRoleAppRoleAssociation mainRoleAppRoleAssociation = new(request.RoleId,
            request.MainRoleId);
        await repository.AddAsync(mainRoleAppRoleAssociation, cancellationToken);
        
        return new("Rol ilişki kaydı başarılı!");
    }
}
