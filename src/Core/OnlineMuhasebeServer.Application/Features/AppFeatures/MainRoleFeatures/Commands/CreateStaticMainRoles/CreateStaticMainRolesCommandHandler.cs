using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;
using OnlineMuhasebeServer.Domain.Entities;
using OnlineMuhasebeServer.Domain.Repositories.ApplicationDbContext;
using OnlineMuhasebeServer.Domain.Roles;
using System.ComponentModel.Design;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRoles;

public sealed class CreateStaticMainRolesCommandHandler(IMainRoleRepository repository) : ICommandHandler<CreateStaticMainRolesCommand, MessageResponse>
{

    public async Task<MessageResponse> Handle(CreateStaticMainRolesCommand request, CancellationToken cancellationToken)
    {
        List<MainRole> mainRoles = RoleList.GetStaticMainRoles();
        List<MainRole> newMainRoles= new List<MainRole>();
        foreach (var mainRole in mainRoles)
        {
            MainRole checkMainRole = await repository.GetByExpressionAsync(p => p.Title == mainRole.Title && p.CompanyId == mainRole.CompanyId, cancellationToken);
            if (checkMainRole == null) newMainRoles.Add(mainRole);
        }

        await repository.AddRangeAsync(newMainRoles, cancellationToken);
        return new("Tüm static roller başarıyla oluşturuldu!");
    }
}
