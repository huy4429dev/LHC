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
using Microsoft.EntityFrameworkCore;
using ClosedXML.Excel;
using System.IO;

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

            if (HttpContext.Session.Get<Customer>("customer") != null)
            {
                return RedirectToAction("Index", "Home");
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
            if (HttpContext.Session.Get<Customer>("customer") != null)
            {
                return RedirectToAction("Index", "Home");
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


        [HttpGet("dang-xuat")]
        public IActionResult CustomerLogout()
        {
            if (HttpContext.Session.Get<Customer>("customer") != null)
            {
                HttpContext.Session.Clear();
            }

            return View("/Views/Customer/Login.cshtml");
        }



        [HttpGet("kiem-tra-hoa-don")]
        public IActionResult CheckOrder()
        {
            var Customer = HttpContext.Session.Get<Customer>("customer");
            var Data = new List<Order>();
            if (Customer != null)
            {
                Data = db.Orders.Include(c => c.Customer).Where(o => o.CustomerId == Customer.Id).ToList();
            }
            return View("/Views/Customer/CheckOrder.cshtml", Data);
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


        [HttpGet("xuat-hoa-don")]
        public IActionResult Excel()
        {
            var Customer = HttpContext.Session.Get<Customer>("customer");
            var Data = new List<Order>();
            if (Customer != null)
            {
                Data = db.Orders.Include(c => c.Customer).Where(o => o.CustomerId == Customer.Id).ToList();
            }
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Orders");
                var currentRow = 1;

                worksheet.Cell(currentRow, 1).Value = "Id";
                worksheet.Cell(currentRow, 2).Value = "Tên khách hàng";
                worksheet.Cell(currentRow, 3).Value = "Điện thoại";
                worksheet.Cell(currentRow, 4).Value = "Email";
                worksheet.Cell(currentRow, 5).Value = "Địa chỉ";
                worksheet.Cell(currentRow, 6).Value = "Đơn giá";
                worksheet.Cell(currentRow, 7).Value = "Số điện sử dụng";
                worksheet.Cell(currentRow, 8).Value = "Thành tiền";
                worksheet.Cell(currentRow, 9).Value = "Trạng thái";
                for (int i = 0; i < Data.Count(); i++)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = Data[i].Id;
                    worksheet.Cell(currentRow, 2).Value = Data[i].Customer.FullName;
                    worksheet.Cell(currentRow, 3).Value = Data[i].Customer.Phone + "\\";
                    worksheet.Cell(currentRow, 4).Value = Data[i].Customer.Email;
                    worksheet.Cell(currentRow, 5).Value = Data[i].Customer.Address;
                    worksheet.Cell(currentRow, 7).Value = Data[i].UnitPrice;
                    worksheet.Cell(currentRow, 7).Value = Data[i].UseValue;
                    worksheet.Cell(currentRow, 8).Value = Data[i].Amount;
                    worksheet.Cell(currentRow, 9).Value = Data[i].Status == OrderStatus.Success ? "Đã xử lý" : "Hoàn thành";
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    string count = DateTime.Now.Millisecond.ToString();
                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "DH" + count + ".xlsx");
                }
            }
        }

        [HttpGet("ho-so")]
        public IActionResult Profile()
        {
            var CustomerSession = HttpContext.Session.Get<Customer>("customer");
            var CustomerInfo = new Customer();
            if (CustomerSession != null)
            {
                CustomerInfo = db.Customers
                                              .Where(item => item.Id == CustomerSession.Id)
                                              .FirstOrDefault();
            }


            return View("/Views/Customer/Profile.cshtml", CustomerInfo);
        }

        [HttpPost("update/{id}")]
        public IActionResult Update(int id, [FromForm] Customer model)
        {
            SkipModelValidate("ConfirmPassword");
            if (ModelState.IsValid)
            {
                var found = db.Customers.Find(id);
                // check category found

                if (found == null)
                {
                    ModelState.AddModelError("Found Customer", "Không tồn tại khách hàng");
                }

                found.FullName = model.FirstName + " " + model.LastName;
                found.LastName = model.LastName;
                found.FirstName = model.FirstName;
                found.Address = model.Address;
                found.BirthDate = model.BirthDate;

                // add category
                found.Status = true;

                db.SaveChanges();

                // alert success to view
                TempData["message"] = "Cập nhật khách hàng thành công";
            }

            return RedirectToAction("Profile");

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