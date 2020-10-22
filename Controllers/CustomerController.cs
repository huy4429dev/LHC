
using Microsoft.AspNetCore.Mvc;
using DVN.Models;
using DVN.Data;
using System.Linq;
using System;

namespace DVN.Controllers
{
    [Route("/khach-hang")]
    public class CustomerController : Controller
    {

        private ApplicationDbContext db;

        public CustomerController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [HttpPost("gui-email")]
        public IActionResult SendEmail([FromBody] CustomerEmail model)
        {

            if (ModelState.IsValid)
            {
                
                model.CreatedTime = DateTime.Now;
                db.CustomerEmails.Add(model);
                db.SaveChanges();
            }

            else
            {
                var error = ModelState.Select(x => x.Value.Errors)
                                       .Where(y => y.Count > 0)
                                       .First();
                return BadRequest(new
                {
                    error = error
                });
            }

            return Ok(new
            {
                success = $"Chúng tôi sẽ gửi lại mail vào địa chỉ {model.Email} của bạn",
                data = model
            });

        }
    }
}