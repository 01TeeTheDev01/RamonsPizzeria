using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using RamonsPizzeria.Models;
using RamonsPizzeria.Pages.CheckOut;

namespace RamonsPizzeria.Pages
{
    public class OrdersModel : PageModel
    {

        public void OnGet()
        {
        }

        public IEnumerable<PizzaOrder> GetPizzaOrders()
        {
            return new ThankYouModel().PizzaOrdersList();
        }
    }
}
