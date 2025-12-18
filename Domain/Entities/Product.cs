namespace Sample.Domain.Entities;

public class Product
{
    public Guid Id { get; set; }
    public double Value { get; set; }
    public int Quantity { get; set; }
    public DateTime BoughtAt { get; set; }
    public Order Order { get; set; } = default!;
}