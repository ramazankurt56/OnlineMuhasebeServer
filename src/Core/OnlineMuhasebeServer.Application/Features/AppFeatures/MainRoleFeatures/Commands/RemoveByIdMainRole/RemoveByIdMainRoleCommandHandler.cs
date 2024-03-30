using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;
using OnlineMuhasebeServer.Domain.Repositories.ApplicationDbContext;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveMainRole;

public sealed class RemoveByIdMainRoleCommandHandler(IMainRoleRepository repository) : ICommandHandler<RemoveByIdMainRoleCommand, MessageResponse>
{


    public async Task<MessageResponse> Handle(RemoveByIdMainRoleCommand request, CancellationToken cancellationToken)
    {
        await repository.DeleteByIdAsync(request.Id.ToString());
        return new("Ana rol kaydı başarıyla silindi!");
    }
}
