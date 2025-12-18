using Microsoft.AspNetCore.Mvc;
using Sample.Application.Abstractions;
using Sample.Domain.Entities;

namespace Sample.Presentation;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult Get([FromServices] IProductService _service, [FromRoute] Guid id)
    {
        var order = _service.Get(id);

        return Ok(order);
    }

    [HttpPost("{id}/buy")]
    public IActionResult Buy([FromServices] IProductService _service, Product product)
    {
        _service.Buy(product);

        return Ok();
    }
}