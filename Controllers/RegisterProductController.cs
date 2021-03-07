using Microsoft.AspNetCore.Mvc;
using DVN.Data;
using DVN.Models;
using DVN.ViewModels;
using System.Linq;
using System;
using Microsoft.Extensions.Configuration;
using DVN.Extension;

namespace DVN.Controllers
{
    [Route("/dang-ky-su-dung")]
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
            var option = db.Options.Where(item => item.Type == "UnitpriceRegister").FirstOrDefault();

            float unitPrice = 0;
            if (option != null)
            {
                unitPrice = float.Parse(option.Value);
            }
            ViewData["unitPrice"] = unitPrice;

            // check login 
            var customer = HttpContext.Session.Get<Customer>("customer");
            if (customer != null)
            {
                var customerInfo = db.Customers.Find(customer.Id);
                ViewData["customerInfo"] = new Customer
                {
                    Address = customerInfo.Address,
                    FirstName = customerInfo.FirstName,
                    LastName = customerInfo.LastName,
                    Phone = customerInfo.Phone,
                    Email = customerInfo.Email
                };
            }

            return View("/Views/RegisterProduct/Index.cshtml");
        }

        [HttpPost]
        public IActionResult Create([FromForm] RegisterProductViewModel model)
        {

            // get unitprice

            var option = db.Options.Where(item => item.Type == "UnitpriceRegister").FirstOrDefault();

            float unitPrice = 0;
            if (option != null)
            {
                unitPrice = float.Parse(option.Value);
            }

            // get customer info login 

            var customer = HttpContext.Session.Get<Customer>("customer");


            if (ModelState.IsValid)
            {
                var foundCustomer = db.Customers.FirstOrDefault(item => item.Id == customer.Id);
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
                    foundCustomer.Status = false;
                    foundCustomer.BankNumber = HttpContext.Request.Form["BankName"];
                    foundCustomer.BankName = HttpContext.Request.Form["BankNumber"];


                    db.RegisterProducts.Add(new RegisterProduct
                    {
                        CustomerId = customer.Id,
                        Place = model.Place,
                        Roof = model.Roof,
                        Status = RegisterProductStatus.Pendding,
                        Wattage = model.Wattage,
                        UnitPrice = unitPrice,
                        Amount = (float)unitPrice * model.Wattage * 10 / 100 + unitPrice * model.Wattage, // thanh tien
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