using Microsoft.AspNetCore.Mvc;

namespace DVN.Controllers
{
    [Route("/dang-ky-su-dung")]
    public class RegisterProductController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View("/Views/RegisterProduct/Index.cshtml");
        }

    }
}