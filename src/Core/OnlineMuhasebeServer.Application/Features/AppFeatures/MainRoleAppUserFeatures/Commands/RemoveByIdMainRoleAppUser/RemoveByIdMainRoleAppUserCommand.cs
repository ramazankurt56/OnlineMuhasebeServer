using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;
namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleAppUserFeatures.Commands.RemoveByIdMainRoleAppUser;

public sealed record RemoveByIdMainRoleAppUserCommand(
    Guid Id): ICommand<MessageResponse>;
