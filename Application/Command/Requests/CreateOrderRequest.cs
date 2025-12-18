using MediatR;

using Sample.Application.Commands.Responses;

namespace Sample.Application.Commands.Requests;

public class CreateOrderRequest : IRequest<CreateOrderResponse>
{
    public decimal Value { get; set; }
}