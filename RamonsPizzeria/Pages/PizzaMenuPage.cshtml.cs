using System.Runtime.ConstrainedExecution;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using RamonsPizzeria.Models;

namespace RamonsPizzeria.Pages
{
    public class PizzaMenuModel : PageModel
    {
        private static List<PizzasModel> MockPizzasDB = new()
        {
            new PizzasModel
            {
                ImageTitle = "Carbonara",
                PizzaName = "Carbonara",
                TotalPrice = 79.99m
            },
            new PizzasModel
            {
                ImageTitle = "Hawaiian",
                PizzaName = "Hawaiian",
                TotalPrice = 69.99m
            },
            new PizzasModel
            {
                ImageTitle = "Margerita",
                PizzaName = "Margerita",
                TotalPrice = 39.99m
            },
            new PizzasModel
            {
                ImageTitle = "MeatFeast",
                PizzaName = "MeatFeast",
                TotalPrice = 109.99m
            },
            new PizzasModel
            {
                ImageTitle = "Mushroom",
                PizzaName = "Mushroom",
                TotalPrice = 75.99m
            },
            new PizzasModel
            {
                ImageTitle = "Pepperoni",
                PizzaName = "Pepperoni",
                TotalPrice = 66.99m
            },
            new PizzasModel
            {
                ImageTitle = "Seafood",
                PizzaName = "Seafood",
                TotalPrice = 85.99m
            },
            new PizzasModel
            {
                ImageTitle = "Vegetarian",
                PizzaName = "Vegetarian",
                TotalPrice = 63.99m
            },
        };

        public void OnGet()
        {

        }

        public IEnumerable<PizzasModel> GetPizzaMockDB()
        {
            MockPizzasDB = MockPizzasDB.OrderBy(n => n.ImageTitle).ToList();

            return MockPizzasDB;
        }
    }
}
