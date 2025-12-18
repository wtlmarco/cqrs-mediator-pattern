using Microsoft.AspNetCore.Mvc;
using Sample.Application.Abstractions;
using Sample.Application.Commands.Requests;
using Sample.Application.Commands.Responses;

namespace Sample.Presentation;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    [HttpPost]
    public CreateCustomerResponse Create(
        [FromServices] ICreateCustomerHandler handler
        , [FromBody] CreateCustomerRequest command)
    {
        return handler.Handle(command);
    }
}