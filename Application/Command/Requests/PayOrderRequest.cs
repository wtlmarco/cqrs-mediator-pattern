using MediatR;

using Sample.Application.Commands.Responses;

namespace Sample.Application.Commands.Requests;

public class PayOrderRequest : IRequest<PayOrderResponse>
{
    public decimal Amount { get; set; }
}