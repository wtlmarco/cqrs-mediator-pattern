using Microsoft.AspNetCore.Mvc;

using Sample.Application.Abstractions;
using Sample.Application.DTOs;
using Sample.Domain.Entities;

namespace Sample.Presentation;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult Get([FromServices] IProductService _service, [FromRoute] Guid id)
    {
        var product = _service.Get(id);

        //PROBLEMA: Controller mais inteligente realizando por vezes manipulação de dados
        var result = new ProductDto(id, product.Value, product.Quantity);

        return Ok(result);
    }

    [HttpPost("{id}/buy")]
    public IActionResult Buy([FromServices] IProductService _service, Product product)
    {
        _service.Buy(product);

        return Ok();
    }
}