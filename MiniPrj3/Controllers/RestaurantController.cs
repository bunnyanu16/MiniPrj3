using Microsoft.AspNetCore.Mvc;

namespace MiniPrj3.Controllers
{
    public class RestaurantController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
