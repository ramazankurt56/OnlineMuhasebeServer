using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;
using OnlineMuhasebeServer.Domain.Entities.Identity;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Command.UpdateRole;
public sealed class UpdateRoleCommandHandler(RoleManager<AppRole> roleManager) : ICommandHandler<UpdateRoleCommand, MessageResponse>
{

    public async Task<MessageResponse> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
    {
        AppRole role = await roleManager.FindByIdAsync(request.Id);
        if (role == null) throw new Exception("Role bulunamadı!");

        if (role.Code != request.Code)
        {
            AppRole checkCode = await roleManager.Roles.FirstOrDefaultAsync(p => p.Code == request.Code);
            if (checkCode != null) throw new Exception("Bu kod daha önce kaydedilmiş!");
        }

        role.Code = request.Code;
        role.Name = request.Name;
        await roleManager.UpdateAsync(role);
        return new("Role güncelleme işlemi başarıyla tamamlandı!");
    }
}
