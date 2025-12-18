using Sample.Domain.Entities;

namespace Sample.Application.Abstractions;

public interface IOrderRepository
{
    Order Get(Guid id);
}
