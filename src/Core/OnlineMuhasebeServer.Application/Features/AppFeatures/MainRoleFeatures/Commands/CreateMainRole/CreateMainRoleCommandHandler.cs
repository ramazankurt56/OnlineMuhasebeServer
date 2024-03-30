using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;
using OnlineMuhasebeServer.Domain.Entities;
using OnlineMuhasebeServer.Domain.Repositories.ApplicationDbContext;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;

public sealed class CreateMainRoleCommandHandler(IMainRoleRepository repository) : ICommandHandler<CreateMainRoleCommand, MessageResponse>
{

    public async Task<MessageResponse> Handle(CreateMainRoleCommand request, CancellationToken cancellationToken)
    {
        var checkMainRoleTitle = await repository.GetByExpressionAsync(p => p.Title == request.Title &&
        p.CompanyId == request.CompanyId, cancellationToken);
        if (checkMainRoleTitle != null) throw new Exception("Bu rol daha önce kaydedilmiş!");

        MainRole mainRole = new(
            request.Title,
            request.CompanyId != null ? false : true,
            request.CompanyId);

        await repository.AddAsync(mainRole, cancellationToken);

        return new("Ana rol kaydı başarıyla tamamlandı!");
    }
}
