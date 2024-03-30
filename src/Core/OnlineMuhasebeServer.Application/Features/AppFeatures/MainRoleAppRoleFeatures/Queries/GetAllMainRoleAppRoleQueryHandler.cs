using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Repositories.ApplicationDbContext;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleAppRoleFeatures.Queries;

public sealed class GetAllMainRoleAppRoleQueryHandler(IMainRoleAppRoleAssociationRepository repository) : IQueryHandler<GetAllMainRoleAppRoleQuery, GetAllMainRoleAppRoleQueryResponse>
{

    public async Task<GetAllMainRoleAppRoleQueryResponse> Handle(GetAllMainRoleAppRoleQuery request, CancellationToken cancellationToken)
    {
        return new(await repository
            .GetAll()
            .Include("AppRole")
            .Include("MainRole")
            .ToListAsync());
    }
}
