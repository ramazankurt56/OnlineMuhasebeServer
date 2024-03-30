using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;
using OnlineMuhasebeServer.Domain.Entities.Identity;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Command.CreateRole;
internal class CreateRoleCommandHandler(RoleManager<AppRole> roleManager, IMapper mapper) : ICommandHandler<CreateRoleCommand, MessageResponse>
{
    public async Task<MessageResponse> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
    {
        AppRole? role = await roleManager.Roles.FirstOrDefaultAsync(p => p.Code == request.Code);
        if (role != null) throw new Exception("Bu rol daha önce kayıt edilmiş!");
        if (role is null)
        {
            AppRole appRole = mapper.Map<AppRole>(request);
            role.Id = Guid.NewGuid();
            await roleManager.CreateAsync(appRole);
        }


        return new("Role kaydı başarıyla tamamlandı!");
    }
}
