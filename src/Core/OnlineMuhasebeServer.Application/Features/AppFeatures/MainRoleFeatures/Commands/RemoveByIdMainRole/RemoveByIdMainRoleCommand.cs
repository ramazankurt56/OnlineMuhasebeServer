using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveMainRole
{
    public sealed record RemoveByIdMainRoleCommand(
        Guid Id): ICommand<MessageResponse>;
}
