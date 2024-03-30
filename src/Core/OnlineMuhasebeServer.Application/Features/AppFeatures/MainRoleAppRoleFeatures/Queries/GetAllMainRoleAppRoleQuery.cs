using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleAppRoleFeatures.Queries;

public sealed record GetAllMainRoleAppRoleQuery() : IQuery<GetAllMainRoleAppRoleQueryResponse>;
