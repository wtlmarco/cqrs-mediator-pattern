using Sample.Application.Abstractions;
using Sample.Application.Commands.Requests;
using Sample.Application.Commands.Responses;

namespace Sample.Application.Commands.Handlers;

public class CreateCustomerHandler: ICreateCustomerHandler
{
    public CreateCustomerResponse Handle(CreateCustomerRequest request)
    {
        //Validate if client already exists
        
        //Validate entry data

        //Add client in Storage

        //Send greetings mail

        //Return response
        return new CreateCustomerResponse
        {
            Id = Guid.NewGuid(),
            Name = "Client Name",
            Email = "cliente@shop.com",
            Date = DateTime.Now
        };
    }
}