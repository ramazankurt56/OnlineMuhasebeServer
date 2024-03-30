using CleanArchitecture.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Command.CreateRole;
using OnlineMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Command.CreateStaticRoles;
using OnlineMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Command.DeleteRole;
using OnlineMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Command.UpdateRole;
using OnlineMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles;
using OnlineMuhasebeServer.Domain.Dtos;

namespace OnlineMuhasebeServer.Presentation.Controllers;
public class RolesController:ApiController
{
    public RolesController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost]
    public async Task<IActionResult> CreateRole(CreateRoleCommand request, CancellationToken cancellationToken)
    {
        MessageResponse response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpGet]
    public async Task<IActionResult> GetAllRoles()
    {
        GetAllRolesQuery request = new();
        GetAllRolesQueryResponse response = await _mediator.Send(request);
        return Ok(response);
    }
    [HttpPost]
    public async Task<IActionResult> UpdateRole(UpdateRoleCommand request)
    {
        MessageResponse response = await _mediator.Send(request);
        return Ok(response);
    }
    [HttpGet]
    public async Task<IActionResult> DeleteRole(string id)
    {
        DeleteRoleCommand request = new(id);

        MessageResponse response = await _mediator.Send(request);
        return Ok(response);
    }
    [HttpGet]
    public async Task<IActionResult> CreateAllRoles()
    {
        CreateStaticRolesCommand request = new();
        MessageResponse response = await _mediator.Send(request);
        return Ok(response);
    }
}
