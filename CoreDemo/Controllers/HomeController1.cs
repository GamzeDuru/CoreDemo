using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
