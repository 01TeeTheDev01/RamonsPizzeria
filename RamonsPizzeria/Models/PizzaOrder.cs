namespace RamonsPizzeria.Models
{
    public class PizzaOrder
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; } = 0.0m;
        public DateTime TimeOfOrder { get; set; } = DateTime.MinValue;
    }
}
