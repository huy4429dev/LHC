using Microsoft.AspNetCore.Mvc;
using DVN.Data;
using DVN.Models;
using DVN.ViewModels;
using System.Linq;
using System;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using DVN.Extension;

namespace DVN.Admin.Controllers
{
    [Route("/admin/product/register")]
    public class RegisterProductController : Controller
    {
        private ApplicationDbContext db;
        private IConfiguration configuration;
        public RegisterProductController(ApplicationDbContext db, IConfiguration configuration)
        {
            this.db = db;
            this.configuration = configuration;
        }

        [HttpGet]
        public IActionResult Index()
        {
            float unitPrice = float.Parse(configuration.GetSection("Contract").GetSection("Unitprice").Value);
            
            var data = db.RegisterProducts.Include(x => x.Customer).ToList();

            return View("/Views/Admin/RegisterProduct/Index.cshtml",data);
        }

        [HttpGet("{id}")]
        public IActionResult Detail(int id)
        {
            float unitPrice = float.Parse(configuration.GetSection("Contract").GetSection("Unitprice").Value);
            
            var data = db.RegisterProducts.Include(x => x.Customer).FirstOrDefault(item => item.Id == id);

            return View("/Views/Admin/RegisterProduct/Detail.cshtml",data);
        }

        

        [HttpPost]
        public IActionResult Create([FromForm] RegisterProductViewModel model)
        {

            // get unitprice

            float unitPrice = float.Parse(configuration.GetSection("Contract").GetSection("Unitprice").Value);

            // get customer info login 

            var customer = HttpContext.Session.Get<Customer>("customer");


            if (ModelState.IsValid)
            {
                var foundCustomer = db.Customers.FirstOrDefault(item => item.Status && item.Id == customer.Id);
                if (foundCustomer == null)
                {
                    ModelState.AddModelError("NotFoundCustomer", "Tài khoản không khả dụng");
                }
                else
                {

                    foundCustomer.Address = model.Address;
                    foundCustomer.FirstName = model.FirstName;
                    foundCustomer.LastName = model.LastName;
                    foundCustomer.FullName = model.FirstName + " " + model.LastName;
                    foundCustomer.Phone = model.Phone;
                    foundCustomer.Email = model.Email;

                    db.RegisterProducts.Add(new RegisterProduct
                    {
                        CustomerId = customer.Id,
                        Place = model.Place,
                        Roof = model.Roof,
                        Status = RegisterProductStatus.Pendding,
                        Wattage = model.Wattage,
                        UnitPrice = unitPrice,
                        Amount = (float) unitPrice * model.Wattage * 10 / 100  +  unitPrice * model.Wattage  , // thanh tien
                        CreatTime = DateTime.Now

                    });

                    db.SaveChanges();

                    ViewData["RegisterProductSuccess"] = "Đăng ký sử dụng thành công chúng tôi sẽ liên hệ lại cho bạn thông qua số điện thoại: " + model.Phone;


                }

            }

            return View("/Views/RegisterProduct/Index.cshtml");
        }

    }
}