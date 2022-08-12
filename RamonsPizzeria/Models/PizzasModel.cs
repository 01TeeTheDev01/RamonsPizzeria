namespace RamonsPizzeria.Models
{
    public class PizzasModel
    {
        public string ImageTitle { get; set; } = string.Empty;
        public string PizzaName { get; set; } = string.Empty;
        public float BasePrice { get; set; } = 0f;
        public bool TomatoSauce { get; set; }
        public bool ThinBase { get; set; }
        public bool Cheese { get; set; }
        public bool Pepperoni { get; set; }
        public bool Bacon { get; set; }
        public bool Beef { get; set; }
        public bool BBQSauce { get; set; }
        public bool MayonnaiseSauce { get; set; }
        public bool Olives { get; set; }
        public bool Pineapples { get; set; }
        public bool Peppers { get; set; }
        public bool Onions { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
