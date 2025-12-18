using MediatR;

using Sample.Application.DTOs;

namespace Sample.Application.Queries;

public record GetOrderQuery(Guid Id) : IRequest<OrderDto>;

