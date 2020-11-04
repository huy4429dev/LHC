using System;
using System.Linq;
using System.Collections.Generic;
using DVN.Data;
using DVN.Models;
using Microsoft.AspNetCore.Mvc;
using DVN.Services;


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


        public IActionResult Index()
        {

            var Customers = db.Customers.OrderBy(item => item.Id).ToList();

            return View("/Views/Admin/Customer/Index.cshtml", Customers);

        }

        [HttpGet("search")]

        public IActionResult Search(string query)
        {

            query = "%" + query + "%";

            var Books = db.Customers
                               //    .Where(item => EF.Functions.ILike(item.Name, query)
                               //                   || EF.Functions.ILike(item.Description, query)
                               //           )
                               .OrderBy(item => item.Id).ToList();

            return View("/Views/Admin/Customer.cshtml", Books);
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
                    model.FullName = model.FirstName + " " + model.LastName;
                    model.CreatTime = DateTime.Now;
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

            if (ModelState.IsValid)
            {
                var found = db.Customers.Find(id);

                // check category found

                if (found == null)
                {
                    ModelState.AddModelError("Found Cateogry", "Category not found");
                }

                // add category

                // found.Name = model.Name;
                // found.Description = model.Description;

                db.SaveChanges();

                // alert success to view
                TempData["message"] = "Update category success";
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