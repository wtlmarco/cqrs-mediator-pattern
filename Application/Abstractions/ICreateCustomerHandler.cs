using Sample.Application.Commands.Requests;
using Sample.Application.Commands.Responses;

namespace Sample.Application.Abstractions;

public interface ICreateCustomerHandler
{
    CreateCustomerResponse Handle(CreateCustomerRequest request);
}