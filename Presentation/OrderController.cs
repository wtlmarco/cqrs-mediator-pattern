using Microsoft.AspNetCore.Mvc;

using MediatR;

using Sample.Application.Commands.Requests;
using Sample.Application.Commands.Responses;
using Sample.Application.DTOs;
using Sample.Application.Queries;

namespace Sample.Presentation;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    [HttpGet("{id}")]
    public async Task<OrderDto> Get([FromServices] IMediator mediator, Guid id)
    {
        return await mediator.Send(new GetOrderQuery(id));
    }

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