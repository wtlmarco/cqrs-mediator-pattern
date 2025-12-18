using Sample.Application.Abstractions;
using Sample.Domain.Entities;

namespace Sample.Infrastructure
{
    public class ProductRepository : IProductRepository
    {
        public Product Get(Guid id) => new Product
        {
            Id = Guid.NewGuid(),
            Value = 100.0,
            Quantity = 0
        };
    }
}
