
using Microsoft.AspNetCore.Mvc;
using DVN.Data;
using DVN.Models;
using DVN.ViewModels;
using System.Linq;
using System;

namespace DVN.Controllers
{
    [Route("/lien-he")]
    public class ContactController : Controller
    {

        private ApplicationDbContext db;

        public ContactController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View("/Views/Contact/Index.cshtml");
        }

        [HttpPost]
        public IActionResult SendContact([FromBody] Contact model)
        {

            if (ModelState.IsValid)
            {
                model.CreatedTime = DateTime.Now;
                db.Contacts.Add(model);
                db.SaveChanges();
                ViewData["SendContactSuccess"] = "Gửi liên hệ thành công chúng tôi sẽ giải đáp thắc mắc của bạn qua địa chỉ emai" + model.Email;
                return Ok(new
                {
                    data = model,
                    Success = "Gửi liên hệ thành công chúng tôi sẽ giải đáp thắc mắc của bạn qua địa chỉ emai" + model.Email
                });
            }

            var error = ModelState.Select(x => x.Value.Errors)
                       .Where(y => y.Count > 0)
                       .First();
            return BadRequest(new
            {
                error = error
            });

        }



    }
}