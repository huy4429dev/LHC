using System;
using System.Linq;
using System.Collections.Generic;
using DVN.Data;
using DVN.Models;
using Microsoft.AspNetCore.Mvc;
using DVN.Services;
using DVN.Extension;

namespace DVN.Admin.Controllers
{
    public class DashBoardController : Controller
    {

        private readonly ApplicationDbContext db;
        private UserService userService;

        public DashBoardController()
        {
  
        }


        [HttpGet("admin/dashboard")]
        public IActionResult Index()
        {

            // var user = userService.GetUser();

            // if (user == null)
            // {
            //     return RedirectToAction("Index", "Login");
            // }

            // ViewData["User"] = new User
            // {
            //     Username = user.Username
            // };

            return View("/Views/Admin/Dashboard/Index.cshtml");

        }


    }
}