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
using DocumentFormat.OpenXml.Spreadsheet;

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
            if (option != null)
            {
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
                var order = db.Orders.Include(o => o.Customer).FirstOrDefault(o => o.Id == id);

                var worksheet = workbook.Worksheets.Add("Orders");
                worksheet.Style.Font.FontName = "Arial";

                var rangeBrand = worksheet.Range(1, 1, 1, 6);
                rangeBrand.Value = "Công ty điện lực Điện Biên - Chi nhánh tổng công ty điện lực miền Bắc";
                rangeBrand.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rangeBrand.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                rangeBrand.Merge();

                var rangeNameCompany = worksheet.Range(2, 1, 2, 6);

                rangeNameCompany.Value = "Điện Lực Thành Phố Điện Biên Phủ";
                rangeNameCompany.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rangeNameCompany.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                rangeNameCompany.Style.Font.Bold = true;
                rangeNameCompany.Merge();

                var range = worksheet.Range(4, 4, 5, 15);
                range.Value = "BẢNG KÊ THANH TOÁN TIỀN ĐIỆN MẶT TRỜI MÁI NHÀ";
                range.Style.Font.FontSize = 25;
                range.Style.Font.Bold = true;
                range.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                range.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                var range2 = worksheet.Range(6, 4, 6, 15);
                range2.Value = "Ngày tạo đơn: " + order.CreatTime.ToString("dd/MM/yyyy");
                range2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                range2.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                range.Merge();
                range2.Merge();
                var currentRow = 8;
                worksheet.Row(currentRow).Style.Font.Bold = true;
                worksheet.Cell(currentRow, 6).Value = "#";
                worksheet.Cell(currentRow, 7).Value = "Tên khách hàng";
                worksheet.Cell(currentRow, 8).Value = "Điện thoại";
                worksheet.Cell(currentRow, 9).Value = "Email";
                // worksheet.Cell(currentRow, 10).Value = "Địa chỉ";
                worksheet.Cell(currentRow, 10).Value = "Đơn giá";
                worksheet.Cell(currentRow, 11).Value = "Số điện sử dụng";
                worksheet.Cell(currentRow, 12).Value = "Thành tiền";
                worksheet.Cell(currentRow, 13).Value = "Trạng thái";

                currentRow++;
                worksheet.Cell(currentRow, 6).Value = "DH" + order.Id;
                worksheet.Cell(currentRow, 7).Value = order.Customer.FullName;
                worksheet.Cell(currentRow, 8).Value = order.Customer.Phone + "\\";
                worksheet.Cell(currentRow, 9).Value = order.Customer.Email;
                // worksheet.Cell(currentRow, 10).Value = order.Customer.Address;
                worksheet.Cell(currentRow, 10).Value = order.UnitPrice;
                worksheet.Cell(currentRow, 11).Value = order.UseValue;
                worksheet.Cell(currentRow, 12).Value = order.Amount;
                worksheet.Cell(currentRow, 13).Value = order.Status == OrderStatus.Success ? "Đã xử lý" : "Chưa xử lý";
                var range3 = worksheet.Range(8, 6, currentRow, 13);
                range3.Style.Border.SetOutsideBorder(XLBorderStyleValues.Thick);
                worksheet.Rows().AdjustToContents();
                worksheet.Columns().AdjustToContents();


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