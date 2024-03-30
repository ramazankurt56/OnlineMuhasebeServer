using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleAppUserFeatures.Commands.CreateMainRoleAppUser;

public sealed record CreateMainRoleAppUserCommand(
    Guid UserId,
    Guid MainRoleId,
    Guid CompanyId) : ICommand<MessageResponse>;

