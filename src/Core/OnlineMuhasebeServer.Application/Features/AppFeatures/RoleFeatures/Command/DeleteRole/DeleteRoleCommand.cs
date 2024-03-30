using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Command.DeleteRole;
public sealed record DeleteRoleCommand(
        string Id)
        : ICommand<MessageResponse>;