using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleAppRoleFeatures.Commands.RemoveByIdMainRoleAppRole;


public sealed record RemoveByIdMainRoleAppRoleCommand(
    Guid Id) : ICommand<MessageResponse>;

