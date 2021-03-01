using System;
using System.Linq;
using System.Collections.Generic;
using DVN.Data;
using DVN.Models;
using Microsoft.AspNetCore.Mvc;
using DVN.Services;
using Microsoft.EntityFrameworkCore;

namespace DVN.Admin.Controllers
{
    [Route("/admin/customer")]
    public class CustomerController : Controller
    {

        private readonly ApplicationDbContext db;

        public CustomerController(ApplicationDbContext db)
        {

            this.db = db;
        }


        public IActionResult Index(int page = 1, int pageSize = 25)
        {

            var query = db.Customers.AsQueryable();
            var Customers = query
                              .OrderByDescending(item => item.Id)
                              .Skip((page - 1) * pageSize)
                              .Take(pageSize)
                              .ToList();

            ViewBag.TotalPage = query.Count() % pageSize == 0 ? query.Count() / pageSize : query.Count() / pageSize + 1;
            ViewBag.CurentPage = page;
            return View("/Views/Admin/Customer/Index.cshtml", Customers);

        }

        [HttpGet("search")]

        public IActionResult Search(string query, DateTime? fillDate, int page = 1, int pageSize = 25)
        {
            var Customers = new List<Customer>();
            var sql = db.Customers.AsNoTracking();
            if (!string.IsNullOrWhiteSpace(query))
            {
                query = "%" + query + "%";
                sql = sql.Where(item => EF.Functions.ILike(item.Username, query)
                                        || EF.Functions.ILike(item.Address, query)
                                        || EF.Functions.ILike(item.FullName, query)
                                        || EF.Functions.ILike(item.Phone, query)
                               );
            }

            if (fillDate.HasValue)
            {
                sql = sql.Where(item => item.CreatTime == fillDate);
            }

            Customers = sql.OrderByDescending(item => item.Id)
                     .Skip((page - 1) * pageSize)
                     .Take(pageSize)
                     .ToList();

            ViewBag.TotalPage = sql.Count() % pageSize == 0 ? sql.Count() / pageSize : sql.Count() / pageSize + 1;
            ViewBag.CurentPage = page;

            return View("/Views/Admin/Customer/Index.cshtml", Customers);
        }


        [HttpPost()]
        public IActionResult Create([FromForm] Customer model)
        {
            SkipModelValidate("ConfirmPassword");

            if (ModelState.IsValid)
            {

                var found = db.Customers.Any(item => item.Username == model.Username || item.Email == model.Email);

                if (found)
                {
                    ModelState.AddModelError("Found Customer", "Khách hàng đã tồn tại");
                }
                else
                {
                    string key = "mot cai key khong thang nao biet";
                    model.Status = true;
                    model.CreatTime = DateTime.Now;
                    model.Password = AesOperation.EncryptString(key, model.Password);
                    model.Status = true;
                    db.Customers.Add(model);
                    db.SaveChanges();
                    TempData["message"] = "Thêm mới khách hàng thành công";
                }

            }
            else
            {
                TempData["Error"] = ModelState.Select(x => x.Value.Errors)
                                  .Where(y => y.Count > 0)
                                  .First()
                                  .Select(m => m.ErrorMessage)
                                  .First();

            }

            return RedirectToAction("Index");

        }

        [HttpPost("update/{id}")]
        public IActionResult Update(int id, [FromForm] Customer model)
        {

            SkipModelValidate("ConfirmPassword");
            SkipModelValidate("Username");
            SkipModelValidate("Status");
            SkipModelValidate("Password");
            SkipModelValidate("BirthDate");

            if (ModelState.IsValid)
            {

                var found = db.Customers.Find(id);
                if (found == null)
                {
                    ModelState.AddModelError("Found Customer", "Không tồn tại khách hàng");
                }

                if (!ModelState.IsValid)
                {
                    var checkBirthDate = ModelState.Keys.Select(item => item == "BirthDate");
                    if (checkBirthDate != null)
                    {
                        model.BirthDate = found.BirthDate;
                    }
                }

                found.Address = model.Address;
                found.FullName = model.FirstName + model.LastName;
                found.BirthDate = model.BirthDate;
                found.Phone = model.Phone;
                found.Status = model.Status;
                found.IdentityCard = model.IdentityCard;
                found.Gender = model.Gender;
                db.SaveChanges();

                // alert success to view
                TempData["message"] = "Cập nhật khách hàng thành công";
            }
            return RedirectToAction("Index");

        }

        [HttpPost("delete/{id}")]

        public IActionResult Delete(int id)
        {

            var found = db.Customers.Find(id);

            // check category found

            if (found == null)
            {
                ModelState.AddModelError("Found Customer", "Customer not found");
            }

            db.Customers.Remove(found);
            db.SaveChanges();

            TempData["message"] = "Xóa khách hàng thành công";

            return RedirectToAction("Index");
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