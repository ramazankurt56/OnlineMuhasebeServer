using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;
using OnlineMuhasebeServer.Domain.Entities.Identity;
using OnlineMuhasebeServer.Domain.Roles;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Command.CreateStaticRoles;
public sealed class CreateStaticRolesCommandHandler(RoleManager<AppRole> roleManager) : ICommandHandler<CreateStaticRolesCommand, MessageResponse>
{
    public async Task<MessageResponse> Handle(CreateStaticRolesCommand request, CancellationToken cancellationToken)
    {
        IList<AppRole> originalRoleList = RoleList.GetStaticRoles();
        IList<AppRole> newRoleList = new List<AppRole>();

        foreach (var role in originalRoleList)
        {
            AppRole? checkRole = await roleManager.Roles.FirstOrDefaultAsync(p => p.Code == role.Code);
            if (checkRole == null) await roleManager.CreateAsync(role);

        }

        return new("Roller başarıyla oluşturuldu!");
    }
}