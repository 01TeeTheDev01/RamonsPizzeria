using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using RamonsPizzeria.Models;

namespace RamonsPizzeria.Pages.CheckOut
{
    [BindProperties(SupportsGet = true)]
    public class CheckOutModel : PageModel
    {
        public string PizzaName { get; set; } = string.Empty;
        public string ImageTitle { get; set; } = string.Empty;
        public static decimal Price { get; set; }

        public void OnGet(PizzasModel model)
        {
            try
            {
                var list = new PizzaMenuModel().GetPizzaMockDB();

                if (string.IsNullOrEmpty(model.PizzaName) && string.IsNullOrWhiteSpace(model.PizzaName) &&
                    string.IsNullOrEmpty(model.ImageTitle) && string.IsNullOrWhiteSpace(model.ImageTitle))
                {
                    PizzaName = "tee's custom pizza";
                    ImageTitle = "Create";
                    Price = model.TotalPrice;
                }
                else if (!string.IsNullOrEmpty(model.ImageTitle) && !string.IsNullOrWhiteSpace(model.ImageTitle))
                {
                    var pizza = list.FirstOrDefault(img => img.ImageTitle == model.ImageTitle);

                    if (pizza != null)
                    {
                        PizzaName = pizza.PizzaName;
                        ImageTitle = pizza.ImageTitle;
                        Price = pizza.TotalPrice;
                    }
                }
            }
            catch (Exception ex)
            {
                RedirectToPage("/Error", new { ex.Source, ex.Message });
            }
        }
    }
}
