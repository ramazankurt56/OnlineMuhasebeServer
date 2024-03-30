using CleanArchitecture.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineMuhasebeServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OnlineMuhasebeServer.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabase;
using OnlineMuhasebeServer.Domain.Dtos;
using System.Threading;

namespace OnlineMuhasebeServer.Presentation.Controllers;
public class CompaniesController : ApiController
{
    public CompaniesController(IMediator mediator) : base(mediator)
    {
    }
    [HttpPost]
    public async Task<IActionResult> CreateCompany(CreateCompanyCommand request,CancellationToken cancellationToken)
    {
        MessageResponse response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpGet]
    public async Task<IActionResult> MigrateCompanyDatabase(CancellationToken cancellationToken)
    {
        MigrateCompanyDatabaseCommand request = new();
        MessageResponse response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}
