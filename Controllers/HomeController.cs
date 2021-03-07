using Microsoft.AspNetCore.Mvc;
using DVN.Data;
using DVN.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DVN.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db;
        public HomeController (ApplicationDbContext db){
            this.db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewData["post"] = db.Posts
                                  .OrderByDescending(item => item.CreatedAt)
                                  .Take(3)
                                  .ToList();
            return View("/Views/Home/Index.cshtml");
        }

    }
}