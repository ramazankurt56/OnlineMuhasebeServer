using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.AppUserCompanyFeatures.Commands.CreateAppUserCompany;

public sealed record CreateAppUserCompanyCommand(
    Guid AppUserId,
    Guid CompanyId) : ICommand<MessageResponse>;

