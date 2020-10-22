using System;
using System.Linq;
using System.Collections.Generic;
using DVN.Data;
using DVN.Models;
using Microsoft.AspNetCore.Mvc;
using DVN.Services;


namespace DVN.Controllers
{
    public class AdminController : Controller
    {

        private readonly ApplicationDbContext db;

        public AdminController(ApplicationDbContext db)
        {

            // hàm khởi tạo

            this.db = db;  // tạo object dbcontext để thao tác với db 
        }


        [HttpGet("admin/make-admin")]
        public IActionResult CreateAdmin()
        {

            string key = "mot cai key khong thang nao biet";

            db.SaveChanges(); // add vao db


            var admin = new User
            {
                Username = "admin",
                Email = "admin@gmail.com",
                Status = true,
                Password = AesOperation.EncryptString(key,"123456"),
                CreatTime = DateTime.Now,
            };

            db.Users.Add(admin);
            db.SaveChanges();

            return Ok("admin created !");
        }
        
   
   
    }
}