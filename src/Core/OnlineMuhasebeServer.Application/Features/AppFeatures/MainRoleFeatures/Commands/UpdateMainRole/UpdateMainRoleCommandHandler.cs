using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;
using OnlineMuhasebeServer.Domain.Entities;
using OnlineMuhasebeServer.Domain.Repositories.ApplicationDbContext;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.UpdateMainRole;

public sealed class UpdateMainRoleCommandHandler(IMainRoleRepository repository) : ICommandHandler<UpdateMainRoleCommand, MessageResponse>
{
    public async Task<MessageResponse> Handle(UpdateMainRoleCommand request, CancellationToken cancellationToken)
    {
        MainRole mainRole = await repository.GetByExpressionAsync(p=>p.Id==request.Id,cancellationToken);
        if (mainRole == null) throw new Exception("Bu ana rol bulunamadı!");

        if (mainRole.Title == request.Title) throw new Exception("Güncellemeye çalıştığınız ana rol adı eski adı ile aynı!");

        if (mainRole.Title != request.Title)
        {
            MainRole checkMainRoleTitle = await repository.
                GetByExpressionAsync(p=>p.Title==request.Title && p.CompanyId== mainRole.CompanyId,cancellationToken);
            if (checkMainRoleTitle != null) throw new Exception("Bu rol adı daha önce kullanılmış!");
        }           

        mainRole.Title = request.Title;
        repository.Update(mainRole);
        return new("Ana rol kaydı başarıyla güncellendi!");
    }
}
