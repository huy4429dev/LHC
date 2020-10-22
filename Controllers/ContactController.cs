
using Microsoft.AspNetCore.Mvc;

namespace DVN.Controllers
{
    [Route("/lien-he")]
    public class ContactController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View("/Views/Contact/Index.cshtml");
        }

    }
}