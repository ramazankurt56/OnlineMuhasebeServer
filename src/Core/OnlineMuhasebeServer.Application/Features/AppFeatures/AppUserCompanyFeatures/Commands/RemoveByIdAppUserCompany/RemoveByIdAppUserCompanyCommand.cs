using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.AppUserCompanyFeatures.Commands.RemoveByIdAppUserCompany;


public sealed record RemoveByIdAppUserCompanyCommand(
    Guid Id): ICommand<MessageResponse>;
