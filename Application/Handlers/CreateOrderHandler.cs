using MediatR;

using Sample.Application.Commands.Requests;
using Sample.Application.Commands.Responses;

namespace Sample.Application.Commands.Handlers;

public class CreateOrderHandler: IRequestHandler<CreateOrderRequest,CreateOrderResponse>
{
    public async Task<CreateOrderResponse> Handle(CreateOrderRequest request, CancellationToken cancellationToken)
    {
        var result = new CreateOrderResponse
        {
            Id = Guid.NewGuid(),
            Value = request.Value,
            Status = "CREATED",
            CreatedDate = DateTime.Now 
        };

        return await Task.FromResult(result);
    }
}