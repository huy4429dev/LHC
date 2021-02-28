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

    [Route("admin/setting/")]
    public class SettingController : Controller
    {
        private ApplicationDbContext db;

        public SettingController(ApplicationDbContext ctx)
        {
            db = ctx;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var query = db.Options.AsQueryable();
            var data = query
                              .FirstOrDefault();

            return View("Views/Admin/Setting/Index.cshtml", data);
        }

        [HttpPost]
        public IActionResult SetOption(Option model)
        {
            var query = db.Options.AsQueryable();
            var data = query.Where(item => item.Type == "Unitprice")
                                           .FirstOrDefault();

            if (ModelState.IsValid)
            {

                if (data == null)
                {
                    db.Options.Add(new Option
                    {
                        Type = "Unitprice",
                        Value = model.Value
                    });
                }
                else
                {
                    data.Value = model.Value;
                }

                db.SaveChanges();
            }

            return View("Views/Admin/Setting/Index.cshtml", data);
        }
    }
}