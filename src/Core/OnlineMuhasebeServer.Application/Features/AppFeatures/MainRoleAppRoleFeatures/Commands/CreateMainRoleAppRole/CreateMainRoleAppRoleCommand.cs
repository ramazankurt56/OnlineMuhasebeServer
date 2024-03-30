using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleAppRoleFeatures.Commands.CreateMainRoleAppRole;

public sealed record CreateMainRoleAppRoleCommand(
    Guid RoleId,
    Guid MainRoleId) : ICommand<MessageResponse>;

