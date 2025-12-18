namespace Sample.Application.Commands.Responses;

public class PayOrderResponse
{
    public Guid Id { get; set; }
    public decimal Amount { get; set; }
    public string Status { get; set; }
    public DateTime PaidAt { get; set; }
}