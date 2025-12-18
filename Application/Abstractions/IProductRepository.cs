using Sample.Domain.Entities;

namespace Sample.Application.Abstractions;

public interface IProductRepository
{
    Product Get(Guid id);
}
