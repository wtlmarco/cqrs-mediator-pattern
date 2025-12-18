namespace Sample.Domain.Entities
{
    public class Customer
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = default!;
        public DateTime BirthDate { get; private set; }
        public ICollection<Order> Orders { get; private set; } = new List<Order>();
    }
}
