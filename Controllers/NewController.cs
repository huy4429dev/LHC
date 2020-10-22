using Microsoft.AspNetCore.Mvc;

namespace DVN.Controllers
{
    [Route("/tin-tuc")]
    public class NewController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View("/Views/News/Index.cshtml");
        }

    }
}