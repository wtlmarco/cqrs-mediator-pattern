namespace Sample.Application.Commands.Responses;

public class CreateOrderResponse
{
    public Guid Id { get; set; }
    public decimal Value { get; set; }
    public string Status { get; set; }
    public DateTime CreatedDate { get; set; }
}