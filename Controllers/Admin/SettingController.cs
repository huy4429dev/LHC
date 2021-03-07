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
            var Unitprice = query.Where(item => item.Type == "Unitprice")
                                           .FirstOrDefault();
            var UnitpriceRegister = query.Where(item => item.Type == "UnitpriceRegister")
                                           .FirstOrDefault();
            if(Unitprice  == null){
                Unitprice = new Option {
                    Value = "0"
                };
            }

            if(UnitpriceRegister  == null){
                UnitpriceRegister = new Option {
                    Value = "0"
                };
            }
            var data = new OptionView
            {
                Unitprice = float.Parse(Unitprice.Value),
                UnitpriceRegister = float.Parse(UnitpriceRegister.Value),
            };

            return View("Views/Admin/Setting/Index.cshtml", data);
        }

        [HttpPost]
        public IActionResult SetOption(Option model)
        {
            var query = db.Options.AsQueryable();
            var Unitprice = query.Where(item => item.Type == "Unitprice")
                                           .FirstOrDefault();

            var UnitpriceRegister = query.Where(item => item.Type == "UnitpriceRegister")
                                           .FirstOrDefault();


            if (ModelState.IsValid)
            {

                if (Unitprice == null)
                {
                    db.Options.Add(new Option
                    {
                        Type = "Unitprice",
                        Value = Request.Form["Unitprice"]

                    });
                }
                else
                {
                    Unitprice.Value = Request.Form["Unitprice"];
                }

                if (UnitpriceRegister == null)
                {
                    db.Options.Add(new Option
                    {
                        Type = "UnitpriceRegister",
                        Value = Request.Form["UnitpriceRegister"]

                    });
                }
                else
                {
                    UnitpriceRegister.Value = Request.Form["UnitpriceRegister"];
                }

                db.SaveChanges();
            }

            var data = new OptionView
            {
                Unitprice = float.Parse(Unitprice.Value),
                UnitpriceRegister = float.Parse(UnitpriceRegister.Value),
            };

            return View("Views/Admin/Setting/Index.cshtml", data);
        }

    }


}