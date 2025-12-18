namespace Sample.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public DateTime BirthDate { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
