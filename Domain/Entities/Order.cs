using Sample.Domain.Entities;

namespace Sample.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public double Total { get; set; }
        public Customer Customer { get; set; } = default!;
        public ICollection<Product>? Products { get; set; } = new List<Product>();
    }
}
