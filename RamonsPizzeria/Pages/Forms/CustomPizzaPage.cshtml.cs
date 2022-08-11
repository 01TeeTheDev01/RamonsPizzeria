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

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            try
            {
                if (Pizza.Onions)
                    TempPrice += onionPrice;

                if (Pizza.BBQSauce)
                    TempPrice += bbqSaucePrice;

                if (Pizza.MayonnaiseSauce)
                    TempPrice += mayoSaucePrice;

                if (Pizza.Pineapples)
                    TempPrice += pineapplePrice;

                if (Pizza.Bacon)
                    TempPrice += baconPrice;

                if (Pizza.Beef)
                    TempPrice += beefPrice;

                if (Pizza.Cheese)
                    TempPrice += cheesePrice;

                if (Pizza.Olives)
                    TempPrice += olivesPrice;

                if (Pizza.Pepperoni)
                    TempPrice += pepperoniPrice;

                if (Pizza.Peppers)
                    TempPrice += pepperPrice;

                if (Pizza.ThinBase)
                    TempPrice += thinBasePrice;

                if (Pizza.TomatoSauce)
                    TempPrice += tomatoSauce;

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
