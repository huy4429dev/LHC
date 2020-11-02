using System;
using System.Linq;
using System.Collections.Generic;
using DVN.Data;
using DVN.Models;
using Microsoft.AspNetCore.Mvc;
using DVN.Services;
using DVN.ViewModels;
using DVN.Extension;
using Microsoft.AspNetCore.Http;
namespace DVN.Controllers
{
    public class LoginController : Controller
    {

        private ApplicationDbContext dbContext;
        public LoginController(ApplicationDbContext _db)
        {   

            this.dbContext = _db;
        }


        [HttpGet("admin/login")]
        public IActionResult Index()
        {


            var user = HttpContext.Session.Get<User>("user");

            if (user != null)
            {
                return RedirectToAction("Index", "DashBoard");
            }

            return View("/Views/Admin/Login/Index.cshtml");

        }


        [HttpPost("admin/login")]
        public IActionResult Login([FromForm] LoginViewModel model)
        {

            if (ModelState.IsValid)
            {
                string UserName = model.UserName;
                string Password = AesOperation.EncryptString("mot cai key khong thang nao biet", model.Password);

                var found = dbContext.Users.FirstOrDefault(item =>
                                                          item.Username == UserName &&
                                                          item.Password == Password
                                                    );

                if (found != null)
                {
                    HttpContext.Session.Set<User>("user", new User
                    {
                        Username = found.Username,
                        Id = found.Id,
                    });

                    return RedirectToAction("Index", "DashBoard");
                }

                // sai ten dang nhap hoac mat khau 
                ModelState.AddModelError(string.Empty, "Sai tên đăng nhập hoặc mật khẩu");

            }

            return View("/Views/Admin/Login/Index.cshtml");

        }


        [HttpGet("admin/logout")]
        public IActionResult LogOut(){

            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Login");
        }

    }
}