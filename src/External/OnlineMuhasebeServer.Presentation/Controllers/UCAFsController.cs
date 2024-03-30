using CleanArchitecture.Presentation.Abstraction;
using MediatR;

namespace OnlineMuhasebeServer.Presentation.Controllers;
public class UCAFsController : ApiController
{
    public UCAFsController(IMediator mediator) : base(mediator)
    {
    }
    //[HttpPost]
    //public async Task<IActionResult> CreateUCAF(CreateUCAFCommand request
    //   ,CancellationToken cancellationToken)
    //{
    //    MessageResponse response = await _mediator.Send(request, cancellationToken);
    //    return Ok(response);
    //}
}
