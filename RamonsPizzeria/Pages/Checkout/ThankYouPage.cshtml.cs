using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using RamonsPizzeria.Models;

namespace RamonsPizzeria.Pages.CheckOut
{
    [BindProperties(SupportsGet = true)]
    public class ThankYouModel : PageModel
    {
        private static readonly List<PizzaOrder> pizzaOrders = new();

        private readonly Random random = new();
        public int OrderId { get; private set; } = 0;
        public decimal OrderPrice { get; private set; } = 0.0m;
        public string OrderName { get; private set; } = string.Empty;
        public string OrderImageName { get; private set; } = string.Empty;

        public IEnumerable<PizzaOrder> PizzaOrdersList()
        { 
            return pizzaOrders;
        }

        public void OnGet(PizzasModel model)
        {
            if (model != null)
            {
                var list = new PizzaMenuModel().GetPizzaMockDB();

                var pizzaId = random.Next(1, int.MaxValue);

                while (pizzaOrders.Exists(p => p.Id == pizzaId))
                {
                    pizzaId = random.Next(1, int.MaxValue);
                }

                var pizzaResult = list.FirstOrDefault(p => p.ImageTitle == model.ImageTitle);

                if (pizzaResult != null)
                {
                    if (!string.IsNullOrEmpty(pizzaResult.PizzaName) &&
                        !string.IsNullOrWhiteSpace(pizzaResult.PizzaName) &&
                        !string.IsNullOrEmpty(pizzaResult.ImageTitle) &&
                        !string.IsNullOrWhiteSpace(pizzaResult.ImageTitle))
                    {
                        OrderId = pizzaId;
                        OrderName = pizzaResult.PizzaName;
                        OrderPrice = pizzaResult.TotalPrice;
                        OrderImageName = pizzaResult.ImageTitle;
                    }
                    else if (!string.IsNullOrEmpty(pizzaResult.PizzaName) &&
                             !string.IsNullOrWhiteSpace(pizzaResult.PizzaName) &&
                             string.IsNullOrEmpty(pizzaResult.ImageTitle) &&
                             string.IsNullOrWhiteSpace(pizzaResult.ImageTitle))
                    {
                        OrderId = pizzaId;
                        OrderName = pizzaResult.PizzaName;
                        OrderPrice = pizzaResult.TotalPrice;
                    }
                }
                else 
                {
                    OrderId = pizzaId;
                    OrderName = "Tee's Custom Pizza";
                    OrderImageName = "Create";
                    OrderPrice = CheckOutModel.Price;
                }

                pizzaOrders.Add(new PizzaOrder
                {
                    Id = OrderId,
                    Name = OrderName,
                    Price = OrderPrice,
                    TimeOfOrder = DateTime.Now.ToUniversalTime()
                });
            }
        }
    }
}
