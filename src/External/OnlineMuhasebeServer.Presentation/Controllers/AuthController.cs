using CleanArchitecture.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineMuhasebeServer.Application.Features.AppFeatures.AuthFeatures.Commands.Login;
using OnlineMuhasebeServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OnlineMuhasebeServer.Domain.Dtos;

namespace OnlineMuhasebeServer.Presentation.Controllers;
public class AuthController : ApiController
{
    public AuthController(IMediator mediator) : base(mediator)
    {
       
    }
    [HttpPost]
    public async Task<IActionResult> Login(LoginCommand request)
    {
        LoginCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }
}
