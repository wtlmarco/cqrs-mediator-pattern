using Sample.Domain.Entities;

namespace Sample.Application.Abstractions;

public interface IProductService
{
    Product Get(Guid id);
    void Buy(Product product);
}