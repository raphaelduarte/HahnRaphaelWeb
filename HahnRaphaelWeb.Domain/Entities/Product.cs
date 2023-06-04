namespace HahnRaphaelWeb.Domain.Entities
{
    public class Product : Entity
    {
        public Product(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double Price { get; private set; }
    }
}
