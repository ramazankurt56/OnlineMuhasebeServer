using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Entities.Identity;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles;
public sealed class GetAllRolesQueryHandler(RoleManager<AppRole> roleManager) : IQueryHandler<GetAllRolesQuery, GetAllRolesQueryResponse>
{


    public async Task<GetAllRolesQueryResponse> Handle(GetAllRolesQuery request, CancellationToken cancellationToken)
    {
        IList<AppRole> roles = await roleManager.Roles.ToListAsync();




        var rolesStartWithM = roleManager.Roles.Where(x => x.Name.StartsWith("m")).ToList();


        return new(roles);
    }
}