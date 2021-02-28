using System.Threading.Tasks;
using DVN.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using DVN.Models;

namespace DVN.Admin.Controllers
{

    [Route("admin/contact/")]
    public class ContactController : Controller
    {
        private ApplicationDbContext db;

        public ContactController(ApplicationDbContext ctx)
        {
            db = ctx;
        }

        [HttpGet]
        public IActionResult Index(int page = 1, int pageSize = 25)
        {
            var query = db.Contacts.AsQueryable();
            var data = query
                              .OrderByDescending(item => item.Id)
                              .Skip((page - 1) * pageSize)
                              .Take(pageSize)
                              .ToList();

            ViewBag.TotalPage = query.Count() % pageSize == 0 ? query.Count() / pageSize : query.Count() / pageSize + 1;
            ViewBag.CurentPage = page;
            return View("Views/Admin/Contact/Index.cshtml", data);
        }

        [HttpGet("search")]
        public IActionResult Search(string query, DateTime? fillDate, int page = 1, int pageSize = 25)
        {
            var Contacts = new List<Contact>();
            var sql = db.Contacts.AsNoTracking();
            if (!string.IsNullOrWhiteSpace(query))
            {
                query = "%" + query + "%";
                sql = sql.Where(item => EF.Functions.ILike(item.Email, query)
                                        || EF.Functions.ILike(item.FullName, query)
                               );
            }

            if (fillDate.HasValue)
            {
                sql = sql.Where(item => item.CreatedTime == fillDate);
            }

            Contacts = sql.OrderByDescending(item => item.Id)
                     .Skip((page - 1) * pageSize)
                     .Take(pageSize)
                     .ToList();

            ViewBag.TotalPage = sql.Count() % pageSize == 0 ? sql.Count() / pageSize : sql.Count() / pageSize + 1;
            ViewBag.CurentPage = page;

            return View("/Views/Admin/Contact/Index.cshtml", Contacts);
        }

        [HttpGet("email-customer")]
        public IActionResult EmailCustomer(int page = 1, int pageSize = 25)
        {

            var query = db.CustomerEmails.AsQueryable();
            var data = query
                              .OrderByDescending(item => item.Id)
                              .Skip((page - 1) * pageSize)
                              .Take(pageSize)
                              .ToList();
            ViewBag.TotalPage = query.Count() % pageSize == 0 ? query.Count() / pageSize : query.Count() / pageSize + 1;
            ViewBag.CurentPage = page;
            return View("Views/Admin/Contact/EmailCustomer.cshtml", data);
        }


        [HttpGet("email-customer/search")]
        public IActionResult SearchEmail(string query, DateTime? fillDate, int page = 1, int pageSize = 25)
        {
            var CustomerEmails = new List<CustomerEmail>();
            var sql = db.CustomerEmails.AsNoTracking();
            if (!string.IsNullOrWhiteSpace(query))
            {
                query = "%" + query + "%";
                sql = sql.Where(item => EF.Functions.ILike(item.Email, query)
                               );
            }

            if (fillDate.HasValue)
            {
                sql = sql.Where(item => item.CreatedTime == fillDate);
            }

            CustomerEmails = sql.OrderByDescending(item => item.Id)
                     .Skip((page - 1) * pageSize)
                     .Take(pageSize)
                     .ToList();

            ViewBag.TotalPage = sql.Count() % pageSize == 0 ? sql.Count() / pageSize : sql.Count() / pageSize + 1;
            ViewBag.CurentPage = page;

            return View("/Views/Admin/Contact/EmailCustomer.cshtml", CustomerEmails);
        }


        [HttpGet("update-status/{id}")]
        public async Task<IActionResult> updateStatus(int Id)
        {

            var Contact = await db.Contacts.FindAsync(Id);
            if (Contact != null)
            {
                Contact.Status = true;
                await db.SaveChangesAsync();
                return Ok(new { status = true });
            }
            return BadRequest("Không tồn tại liên hệ");
        }

    }
}