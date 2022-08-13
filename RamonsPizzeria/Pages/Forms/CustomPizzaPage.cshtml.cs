using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using RamonsPizzeria.Models;

namespace RamonsPizzeria.Pages.Forms
{
    [BindProperties(SupportsGet = true)]
    public class CustomPizzaModel : PageModel
    {
        public PizzasModel Pizza { get; set; }

        private decimal TempPrice = 0.0m;

        private const decimal onionPrice = 4.60m, 
                              bbqSaucePrice = 8.60m, 
                              mayoSaucePrice = 13.50m, 
                              pineapplePrice = 12.50m, 
                              baconPrice = 16.50m, 
                              beefPrice = 20.00m, 
                              cheesePrice = 8.50m, 
                              olivesPrice = 7.50m, 
                              pepperoniPrice = 15.00m, 
                              pepperPrice = 9.50m, 
                              thinBasePrice = 19.99m, 
                              tomatoSauce = 6.50m;

        private readonly MockIngredientsDB db;
        public CustomPizzaModel()
        {
            db = new MockIngredientsDB();
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            try
            {
                if (Pizza.Onions)
                {
                    TempPrice += onionPrice;
                    db.AddIngredient(nameof(Pizza.Onions));
                }

                if (Pizza.BBQSauce)
                {
                    TempPrice += bbqSaucePrice;
                    db.AddIngredient(nameof(Pizza.BBQSauce));
                }

                if (Pizza.MayonnaiseSauce)
                {
                    TempPrice += mayoSaucePrice;
                    db.AddIngredient(nameof(Pizza.MayonnaiseSauce));
                }

                if (Pizza.Pineapples)
                {
                    TempPrice += pineapplePrice;
                    db.AddIngredient(nameof(Pizza.Pineapples));
                }

                if (Pizza.Bacon)
                {
                    TempPrice += baconPrice;
                    db.AddIngredient(nameof(Pizza.Bacon));
                }

                if (Pizza.Beef)
                {
                    TempPrice += beefPrice;
                    db.AddIngredient(nameof(Pizza.Beef));
                }

                if (Pizza.Cheese)
                {
                    TempPrice += cheesePrice;
                    db.AddIngredient(nameof(Pizza.Cheese));
                }

                if (Pizza.Olives)
                {
                    TempPrice += olivesPrice;
                    db.AddIngredient(nameof(Pizza.Olives));
                }

                if (Pizza.Pepperoni)
                {
                    TempPrice += pepperoniPrice;
                    db.AddIngredient(nameof(Pizza.Pepperoni));
                }

                if (Pizza.Peppers)
                {
                    TempPrice += pepperPrice;
                    db.AddIngredient(nameof(Pizza.Peppers));
                }

                if (Pizza.ThinBase)
                {
                    TempPrice += thinBasePrice;
                    db.AddIngredient(nameof(Pizza.ThinBase));
                }

                if (Pizza.TomatoSauce)
                {
                    TempPrice += tomatoSauce;
                    db.AddIngredient(nameof(Pizza.TomatoSauce));
                }

                Pizza.TotalPrice = TempPrice;

                return RedirectToPage("/Checkout/CheckoutPage", new { Pizza.PizzaName, Pizza.TotalPrice });
            }
            catch (Exception ex)
            {
                return RedirectToPage("/Error", ex);
            }
        }
    }
}
