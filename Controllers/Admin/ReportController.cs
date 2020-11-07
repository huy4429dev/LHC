using Microsoft.AspNetCore.Mvc;
using DVN.Data;
using DVN.Models;
using DVN.ViewModels;
using System.Linq;
using System;
using Microsoft.Extensions.Configuration;
using DVN.Extension;
using Microsoft.EntityFrameworkCore;
using ClosedXML.Excel;
using System.IO;

namespace DVN.Admin.Controllers
{
    [Route("/admin/report")]
    public class ReportController : Controller
    {
        private ApplicationDbContext db;
        private IConfiguration configuration;
        public ReportController(ApplicationDbContext db, IConfiguration configuration)
        {
            this.db = db;
            this.configuration = configuration;
        }

        [HttpGet("revenue")]
        public IActionResult Index(int? fromYear)
        {

            int currentYear = DateTime.Now.Year;
            if (fromYear.HasValue)
            {
                currentYear = fromYear.Value;
            }

            ViewData["data"] = db.Orders
            .Where(o => o.CreatTime.Year == currentYear)
            .GroupBy(o => new
            {
                o.CreatTime.Month,
                o.CreatTime.Year
            })
            .Select(g => new
            {
                Month = g.Key.Month,
                value = g.Sum(item => item.Amount)
            })
            .ToList();
          
            return View("Views/Admin/Report/Revenue.cshtml");
        }
    }
}
