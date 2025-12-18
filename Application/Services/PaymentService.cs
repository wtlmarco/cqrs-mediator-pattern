using Sample.Application.Abstractions;
using Sample.Domain.Entities;

namespace Sample.Application.Services;

public class PaymentService: IProductService
{
    public Product Get(Guid id)
    {
        if(id == Guid.Empty)
            throw new Exception("Invalid Id");

        Random random = new Random();
        double randomNumber = random.NextDouble() * (999.99 - 1.00) + 1.00;

        var product = new Product
        {
            BoughtAt = DateTime.Now,
            Value = Double.Round(randomNumber, 2),
            Quantity = 0
        };

        return product;
    }

    public void Buy(Product product)
    {
        if (product.Quantity <= 0)
            throw new Exception("Invalid quantity");

        product.BoughtAt = DateTime.Now;

        product.Order = new Order
        {
            OrderDate = DateTime.Now,
            Total = product.Quantity * product.Value
        };
    }
}