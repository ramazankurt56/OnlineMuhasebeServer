using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Command.CreateRole;
public sealed record CreateRoleCommand(
        string Code,
        string Name) : ICommand<MessageResponse>;