using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;
namespace OnlineMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Command.UpdateRole;
public sealed record UpdateRoleCommand(
        string Id,
        string Code,
        string Name) : ICommand<MessageResponse>;