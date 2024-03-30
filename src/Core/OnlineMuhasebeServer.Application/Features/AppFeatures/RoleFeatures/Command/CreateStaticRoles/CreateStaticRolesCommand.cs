using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Command.CreateStaticRoles;
public sealed record CreateStaticRolesCommand() : ICommand<MessageResponse>;

