using Microsoft.AspNetCore.Mvc;

namespace DVN.Controllers
{
    [Route("/gioi-thieu")]
    public class AboutController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View("/Views/About/Index.cshtml");
        }

    }
}