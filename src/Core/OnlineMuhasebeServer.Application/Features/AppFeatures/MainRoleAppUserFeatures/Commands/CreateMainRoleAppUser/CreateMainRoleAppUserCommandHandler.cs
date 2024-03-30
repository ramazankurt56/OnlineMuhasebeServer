using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;
using OnlineMuhasebeServer.Domain.Entities;
using OnlineMuhasebeServer.Domain.Repositories.ApplicationDbContext;
using System.ComponentModel.Design;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleAppUserFeatures.Commands.CreateMainRoleAppUser;

public sealed class CreateMainRoleAppUserCommandHandler(IMainRoleAppUserAssociationRepository repository) : ICommandHandler<CreateMainRoleAppUserCommand, MessageResponse>
{
    public async Task<MessageResponse> Handle(CreateMainRoleAppUserCommand request, CancellationToken cancellationToken)
    {
        MainRoleAppUserAssociation checkEntity = await repository
            .GetByExpressionAsync(p => p.UserId == request.UserId && p.CompanyId == request.CompanyId && p.MainRoleId == request.MainRoleId, cancellationToken);
        if (checkEntity != null) throw new Exception("Kullanıcı bu role zaten sahip!");

        MainRoleAppUserAssociation mainRoleAndUserRelationship = new(
           request.UserId,request.MainRoleId,request.CompanyId);

        await repository.AddAsync(mainRoleAndUserRelationship, cancellationToken);

        return new("Kullanıcıya rol ataması başarılı!");
    }
}
