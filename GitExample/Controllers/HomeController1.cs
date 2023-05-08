using Microsoft.AspNetCore.Mvc;

namespace GitExample.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
