namespace Sample.Domain.Entities;

public class Order
{
    public Guid Id { get; private set; }
    public DateTime CreateAt { get; private set; }
    public double Total { get; set; }
    public Customer Customer { get; private set; } = default!;
    public ICollection<Product> Products { get; private set; } = new List<Product>();

    public Order() 
    { 
        CreateAt = DateTime.Now;
    }

    public Order(Guid id, DateTime createAt, double total)
    {
        Id = id;
        CreateAt = createAt;
        Total = total;
    }
}
