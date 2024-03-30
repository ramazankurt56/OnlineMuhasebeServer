using OnlineMuhasebeServer.Domain.Entities.Identity;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles;
public sealed record GetAllRolesQueryResponse(
     IList<AppRole> Roles);
