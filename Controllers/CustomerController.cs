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
    [Route("/khach-hang")]
    public class CustomerController : Controller
    {

        private ApplicationDbContext db;

        public CustomerController(ApplicationDbContext _db)
        {
            db = _db;
        }


        [HttpGet("dang-ky")]
        public IActionResult CustomerRegister()
        {

            if(HttpContext.Session.Get<Customer>("customer") != null){
                return RedirectToAction("Index","Home");
            }
            return View("/Views/Customer/Register.cshtml");
        }


        [HttpPost("dang-ky")]
        public IActionResult CustomerRegister([FromForm] Customer model)
        {

            if (ModelState.IsValid)
            {

                var found = db.Customers.FirstOrDefault(item => item.Username == model.Username
                                                                || item.Email == model.Email);
                if (found == null)
                {
                    // add customer 
                    model.FullName = string.Empty;
                    model.CreatTime = DateTime.Now;
                    model.Password = AesOperation.EncryptString("mot cai key khong thang nao biet", model.Password);
                    model.Status = true;
                    db.Customers.Add(model);
                    db.SaveChanges();
                    ViewData["CreateCustomerSuccess"] = "Đăng ký tài khoản thành công";
                }
                else
                {

                    ModelState.AddModelError("Account found", "Tài khoản đã tồn tại");
                }

            }

            return View("/Views/Customer/Register.cshtml");
        }


        [HttpGet("dang-nhap")]
        public IActionResult CustomerLogin()
        {
            if(HttpContext.Session.Get<Customer>("customer") != null){
                return RedirectToAction("Index","Home");
            }

            return View("/Views/Customer/Login.cshtml");
        }

        [HttpPost("dang-nhap")]
        public IActionResult CustomerLogin([FromForm] Customer model)
        {
            SkipModelValidate("Email");
            SkipModelValidate("ConfirmPassword");

            if (ModelState.IsValid)
            {

                model.Password = AesOperation.EncryptString("mot cai key khong thang nao biet", model.Password);

                var found = db.Customers.FirstOrDefault(item => item.Username == model.Username
                                                                && item.Password == model.Password);
                if (found != null)
                {

                    if (found != null)
                    {
                        HttpContext.Session.Set<Customer>("customer", new Customer
                        {
                            Username = found.Username,
                            Id = found.Id,
                        });

                        return RedirectToAction("Index", "Home");
                    }
                }

                ModelState.AddModelError("Account found", "Tài khoản hoặc mật khẩu không chính xác");

            }

            return View("/Views/Customer/Login.cshtml");
        }





        [HttpPost("gui-email")]
        public IActionResult SendEmail([FromBody] CustomerEmail model)
        {

            if (ModelState.IsValid)
            {

                model.CreatedTime = DateTime.Now;
                db.CustomerEmails.Add(model);
                db.SaveChanges();
            }

            else
            {
                var error = ModelState.Select(x => x.Value.Errors)
                                       .Where(y => y.Count > 0)
                                       .First();
                return BadRequest(new
                {
                    error = error
                });
            }

            return Ok(new
            {
                success = $"Chúng tôi sẽ gửi lại mail vào địa chỉ {model.Email} của bạn",
                data = model
            });

        }


        private void SkipModelValidate(string keyword)
        {
            if (ModelState != null)
            {
                foreach (var item in ModelState)
                {
                    if (item.Key.Contains(keyword))
                    {
                        ModelState.Remove(item.Key);
                    }
                }
            }
        }

    }
}