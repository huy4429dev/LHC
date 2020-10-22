using Microsoft.AspNetCore.Mvc;

namespace DVN.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View("/Views/Home/Index.cshtml");
        }

    }
}