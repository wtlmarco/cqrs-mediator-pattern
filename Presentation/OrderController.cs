using Microsoft.AspNetCore.Mvc;

using MediatR;

using Sample.Application.Commands.Requests;
using Sample.Application.Commands.Responses;

namespace Sample.Presentation;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    [HttpPost]
    public async Task<CreateOrderResponse> Create(
        [FromServices] IMediator mediator
        , [FromBody] CreateOrderRequest command)
    {
        return await mediator.Send(command);
    }

    [HttpPost("{id}/pay")]
    public async Task<PayOrderResponse> Pay(
        [FromServices] IMediator mediator
        , [FromBody] PayOrderRequest command)
    {
        return await mediator.Send(command);
    }
}