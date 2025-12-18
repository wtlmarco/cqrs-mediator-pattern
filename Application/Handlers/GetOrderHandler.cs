using MediatR;

using Sample.Application.Abstractions;
using Sample.Application.DTOs;
using Sample.Application.Queries;

namespace Sample.Application.Commands.Handlers;

public class GetOrderHandler: IRequestHandler<GetOrderQuery, OrderDto>
{
    private readonly IOrderRepository _repo;

    public GetOrderHandler(IOrderRepository repo)
    {
        _repo = repo;
    }
    public async Task<OrderDto> Handle(GetOrderQuery request, CancellationToken cancellationToken)
    {
        var order = _repo.Get(request.Id);

        var result = new OrderDto(request.Id, order.CreateAt, order.Total);

        return await Task.FromResult(result);
    }
}