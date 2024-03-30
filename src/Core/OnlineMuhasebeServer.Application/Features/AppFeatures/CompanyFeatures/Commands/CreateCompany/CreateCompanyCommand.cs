using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
public sealed record CreateCompanyCommand(
        string Name ,
 string ServerName,
 string DatabaseName,
 string UserId,
 string Password):ICommand<MessageResponse>;
