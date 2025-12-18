using Sample.Application.Abstractions;
using Sample.Domain.Entities;

namespace Sample.Infrastructure
{
    public class OrderRepository : IOrderRepository
    {
        public Order Get(Guid id) => new Order(
            Guid.NewGuid(),
            DateTime.Now,
            100.0
        );
    }
}
