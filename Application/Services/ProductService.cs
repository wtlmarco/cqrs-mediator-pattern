using MediatR;
using Sample.Application.Abstractions;
using Sample.Application.DTOs;
using Sample.Domain.Entities;

namespace Sample.Application.Services;

public class ProductService: IProductService
{
    private readonly IProductRepository _repo;

    public ProductService(IProductRepository repo)
    {
        _repo = repo;
    }

    public Product Get(Guid id)
    {
        if(id == Guid.Empty)
            throw new Exception("Invalid Id");
        
        var product = _repo.Get(id);

        return product;
    }

    //PROBLEMA: Tendência da classe ter muitas funções e crescer demais dificultando a manutenção
    public void Buy(Product product)
    {
        if (product.Quantity <= 0)
            throw new Exception("Invalid quantity");

        //PROBLEMA: Geralmente é violada a Entidade possibilitando a mudança de estados por qualquer chamador
        product.BoughtAt = DateTime.Now;
                
        var order = new Order();
        order.Products.Add(product);

        //PROBLEMA: Métodos fazem de tudo e regras ficam espalhadas
        order.Total = product.Value * product.Quantity;
    }
}