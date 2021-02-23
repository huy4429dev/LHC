using System.Threading.Tasks;
using DVN.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DVN.Admin.Controllers
{

    [Route("admin/contact/")]
    public class ContactController : Controller
    {
        private ApplicationDbContext _ctx;

        public ContactController(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        public IActionResult Index(int page = 1, int pageSize = 25)
        {
            var query = _ctx.Contacts.AsQueryable();
            var data = query
                              .OrderByDescending(item => item.Id)
                              .Skip((page - 1) * pageSize)
                              .Take(pageSize)
                              .ToList();

            ViewBag.TotalPage = query.Count() % pageSize == 0 ? query.Count() / pageSize : query.Count() / pageSize + 1;
            ViewBag.CurentPage = page;
            return View("Views/Admin/Contact/Index.cshtml", data);
        }
        [HttpGet("email-customer")]
        public  IActionResult EmailCustomer(int page = 1, int pageSize = 25)
        {

            var query = _ctx.CustomerEmails.AsQueryable();
            var data = query
                              .OrderByDescending(item => item.Id)
                              .Skip((page - 1) * pageSize)
                              .Take(pageSize)
                              .ToList();
            ViewBag.TotalPage = query.Count() % pageSize == 0 ? query.Count() / pageSize : query.Count() / pageSize + 1;
            ViewBag.CurentPage = page;
            return View("Views/Admin/Contact/EmailCustomer.cshtml", data);
        }


        [HttpGet("update-status/{id}")]
        public async Task<IActionResult> updateStatus(int Id)
        {

            var Contact = await _ctx.Contacts.FindAsync(Id);
            if (Contact != null)
            {
                Contact.Status = true;
                await _ctx.SaveChangesAsync();
                return Ok(new { status = true });
            }
            return BadRequest("Không tồn tại liên hệ");
        }

    }
}