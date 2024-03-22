using CleanArchitecture.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace OnlineMuhasebeServer.Presentation.Controllers;
public class AuthController : ApiController
{
    public AuthController(IMediator mediator) : base(mediator)
    {
       
    }
    [HttpGet]
    public IActionResult Test()
    {
        return Ok();
    }
}
