using OnlineMuhasebeServer.Domain.Entities;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleAppRoleFeatures.Queries;

public sealed record GetAllMainRoleAppRoleQueryResponse(
    List<MainRoleAppRoleAssociation> MainRoleAppRoleAssociations);
