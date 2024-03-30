using Microsoft.AspNetCore.Identity;
using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;
using OnlineMuhasebeServer.Domain.Entities.Identity;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Command.DeleteRole;
public sealed class DeleteRoleCommandHandler(RoleManager<AppRole> roleManager) : ICommandHandler<DeleteRoleCommand, MessageResponse>
{
    public async Task<MessageResponse> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
    {
        AppRole role = await roleManager.FindByIdAsync(request.Id);
        if (role == null) throw new Exception("Role bulunamadı!");

        await roleManager.DeleteAsync(role);

        return new("Rol başarıyla silindi!");
    }
}