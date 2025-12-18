using MediatR;

using Sample.Application.Commands.Requests;
using Sample.Application.Commands.Responses;

namespace Sample.Application.Commands.Handlers;

public class PayOrderHandler: IRequestHandler<PayOrderRequest,PayOrderResponse>
{
    public async Task<PayOrderResponse> Handle(PayOrderRequest request, CancellationToken cancellationToken)
    {
        var result = new PayOrderResponse
        {
            Id = Guid.NewGuid(),
            Amount = request.Amount,
            Status = "PAID",
            PaidAt = DateTime.Now 
        };

        return await Task.FromResult(result);
    }
}