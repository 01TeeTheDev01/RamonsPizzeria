namespace RamonsPizzeria.Models
{
    public class MockIngredientsDB
    {
        public static List<string>? Ingredients { get; private set; }

        public MockIngredientsDB()
        {
            Ingredients = new List<string>();
            Ingredients.Clear();
        }

        public void AddIngredient(string ingredient)
        {
            if (Ingredients != null)
                Ingredients.Add(ingredient);
        }
    }
}
