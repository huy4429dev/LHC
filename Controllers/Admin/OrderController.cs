using Microsoft.AspNetCore.Mvc;
using DVN.Data;
using DVN.Models;
using DVN.ViewModels;
using System.Linq;
using System;
using Microsoft.Extensions.Configuration;
using DVN.Extension;
using Microsoft.EntityFrameworkCore;
using ClosedXML.Excel;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace DVN.Admin.Controllers
{
    [Route("/admin/order")]
    public class OrderController : Controller
    {
        private ApplicationDbContext db;
        private IConfiguration configuration;
        public OrderController(ApplicationDbContext db, IConfiguration configuration)
        {
            this.db = db;
            this.configuration = configuration;
        }

        [HttpGet]
        public IActionResult Index(int page = 1, int pageSize = 25)
        {
            var query = db.Orders.AsQueryable();
            var data = query.Include(x => x.Customer)
                            .OrderByDescending(item => item.Status)
                            .ThenByDescending(item => item.CreatTime)
                            .ToList();
            ViewBag.TotalPage = query.Count() % pageSize == 0 ? query.Count() / pageSize : query.Count() / pageSize + 1;
            ViewBag.CurentPage = page;
            return View("/Views/Admin/Order/Index.cshtml", data);
        }



        [HttpGet("search")]
        public IActionResult Search(string query, DateTime? fillDate, int page = 1, int pageSize = 25)
        {
            var sql = db.Orders.AsQueryable();
            if (!string.IsNullOrWhiteSpace(query))
            {
                query = query.Trim();
                query = "%" + query + "%";
                sql = sql.Where(item => EF.Functions.ILike(item.Customer.FullName, query) ||
                                        EF.Functions.ILike(item.Customer.Email, query) ||
                                        EF.Functions.ILike(item.Customer.Username, query) ||
                                        EF.Functions.ILike(item.Customer.Phone, query) 
                               );
            }

            if (fillDate.HasValue)
            {
                sql = sql.Where(item => item.CreatTime.Date == fillDate);
            }

            var data = sql.Include(x => x.Customer)
                     .OrderByDescending(item => item.Id)
                     .Skip((page - 1) * pageSize)
                     .Take(pageSize)
                     .ToList();
            ViewBag.TotalPage = sql.Count() % pageSize == 0 ? sql.Count() / pageSize : sql.Count() / pageSize + 1;
            ViewBag.CurentPage = page;
            return View("/Views/Admin/Order/Index.cshtml", data);
        }

        [HttpGet("{id}")]
        public IActionResult Detail(int id)
        {

            var data = db.Orders.Include(x => x.Customer).FirstOrDefault(item => item.Id == id);

            return View("/Views/Admin/Order/Detail.cshtml", data);
        }

        [HttpPost("{id}")]
        public IActionResult Update(int id, [FromForm] Order model)
        {
            var user = HttpContext.Session.Get<User>("user");
            var found = db.Orders.Find(id);
            var option = db.Options.Where(item => item.Type == "Unitprice").FirstOrDefault();
            
            float unitPrice = 0;
            if(option != null){
               unitPrice = float.Parse(option.Value);
            }
            var RegisterProduct = db.RegisterProducts.FirstOrDefault(item => item.CustomerId == found.CustomerId);
            found.Status = model.Status;
            found.UseValue = model.UseValue;
            found.UserverifyId = user?.Id ?? db.Users.Select(u => u.Id).FirstOrDefault();
            found.Amount = (float)unitPrice * RegisterProduct.Wattage * 10 / 100 + unitPrice * RegisterProduct.Wattage;
            if (found.Status == OrderStatus.Dispose)
            {
                TempData["message"] = "Đơn hàng đã được hủy bỏ";
            }
            if (found.Status == OrderStatus.NoProcess)
            {
                TempData["message"] = "Đơn hàng chuyển trạng thái chờ";
            }
            var customer = db.Customers.FirstOrDefault(item => item.Id == found.CustomerId);
            if (model.Status == OrderStatus.Success)
            {
                customer.Status = true;
                TempData["message"] = "Đơn hàng chuyển trạng thái đã xử lý";
            }
            else
            {
                customer.Status = false;
            }

            db.SaveChanges();

            return Redirect(Request.Headers["Referer"].ToString());
        }

        [HttpGet("export/{id}")]
        public IActionResult Excel(int id)
        {
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

                var order = db.Orders.Include(o => o.Customer).FirstOrDefault(o => o.Id == id);
                currentRow++;
                worksheet.Cell(currentRow, 1).Value = order.Id;
                worksheet.Cell(currentRow, 2).Value = order.Customer.FullName;
                worksheet.Cell(currentRow, 3).Value = order.Customer.Phone + "\\";
                worksheet.Cell(currentRow, 4).Value = order.Customer.Email;
                worksheet.Cell(currentRow, 5).Value = order.Customer.Address;
                worksheet.Cell(currentRow, 7).Value = order.UnitPrice;
                worksheet.Cell(currentRow, 7).Value = order.UseValue;
                worksheet.Cell(currentRow, 8).Value = order.Amount;
                worksheet.Cell(currentRow, 9).Value = order.Status == OrderStatus.Success ? "Đã xử lý" : "Chưa xử lý";

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

    }
}