using System;
using System.Linq;
using System.Collections.Generic;
using DVN.Data;
using DVN.Models;
using Microsoft.AspNetCore.Mvc;
using DVN.Services;


namespace DVN.Controllers
{
    public class ProductController : Controller
    {

        private readonly ApplicationDbContext db;

        public ProductController(ApplicationDbContext db)
        {

            // hàm khởi tạo

            this.db = db;  // tạo object dbcontext để thao tác với db 
        }

        
        [HttpGet("admin/product")]
        public IActionResult Index(){

            return View("/Views/Admin/Product/Index.cshtml");
            
        }
   
   
    }
}