using System;
using System.Linq;
using System.Collections.Generic;
using DVN.Data;
using DVN.Models;
using Microsoft.AspNetCore.Mvc;
using DVN.Services;
using DVN.Extension;
using DVN.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace DVN.Admin.Controllers
{
    public class DashBoardController : Controller
    {

        private readonly ApplicationDbContext db;
        private UserService userService;

        public DashBoardController(ApplicationDbContext db)
        {
            this.db = db;
        }


        [HttpGet("admin/dashboard")]
        public IActionResult Index()
        {

            // var user = userService.GetUser();

            // if (user == null)
            // {
            //     return RedirectToAction("Index", "Login");
            // }

            // ViewData["User"] = new User
            // {
            //     Username = user.Username
            // };


            // lấy thời gian hiện tại 

            var Now = DateTime.Now;
            int CurrentMonth = Now.Month;
            int CurrentYeah = Now.Year;
            int CurrentDay = Now.Day;

            //

            var selectedDates = Enumerable.Range(1, CurrentDay)
              .Select(offset => new DataOfDay
              {
                  Day = offset,
                  Count = 0
              })
              .ToList();


            // truy vấn khách hàng mới
            var queryCustomer = db.Customers.AsNoTracking();

            queryCustomer = queryCustomer.Where(item => item.CreatTime.Month == CurrentMonth &&
                                            item.CreatTime.Year == CurrentYeah);

            int NewCustomer = queryCustomer.Count();

            // truy vấn liên hệ mới

            var queryContact = db.Contacts.AsNoTracking();

            queryContact = queryContact.Where(item => item.CreatedTime.Month == CurrentMonth &&
                                            item.CreatedTime.Year == CurrentYeah);

            int Contact = queryContact.Count();

            // truy vấn đơn hàng mới

            var queryOrder = db.Orders.AsNoTracking();

            queryOrder = queryOrder.Where(item => item.CreatTime.Month == CurrentMonth &&
                                            item.CreatTime.Year == CurrentYeah);
            int NewOrder = queryOrder.Count();

            // truy vấn đơn hàng không thành công

            int OrderDepose = queryOrder.Where(item => item.Status == false).Count();



            // thống kê theo ngày lượng khách hàng mới

            var newCustomerOfDay = queryCustomer.GroupBy(item => new
            {
                item.CreatTime.Year,
                item.CreatTime.Month,
                item.CreatTime.Day
            })
            .Select(g => new DataOfDay
            {
                Day = g.Key.Day,
                Count = g.Count()
            })
            .OrderBy(g => g.Day)
            .ToList();

            newCustomerOfDay = newCustomerOfDay.Union(
                       selectedDates
                       .Where(e => !newCustomerOfDay.Select(x => x.Day).Contains(e.Day)))
                       .OrderBy(x => x.Day)
                       .ToList();

            // thống kê theo ngày lượng liên hệ hàng mới

            var newContactOfDay = queryContact.GroupBy(item => new
            {
                item.CreatedTime.Year,
                item.CreatedTime.Month,
                item.CreatedTime.Day
            })
           .Select(g => new DataOfDay
           {
               Day = g.Key.Day,
               Count = g.Count()
           })
            .ToList();

            newContactOfDay = newContactOfDay.Union(
              selectedDates
              .Where(e => !newContactOfDay.Select(x => x.Day).Contains(e.Day)))
              .OrderBy(x => x.Day)
              .ToList();


            // thống kê theo ngày lượng đơn hàng mới

            var newOrderOfDay = queryOrder.GroupBy(item => new
            {
                item.CreatTime.Year,
                item.CreatTime.Month,
                item.CreatTime.Day
            })
            .Select(g => new DataOfDay
            {
                Day = g.Key.Day,
                Count = g.Count()
            })
            .ToList();

            newOrderOfDay = newOrderOfDay.Union(
        selectedDates
        .Where(e => !newOrderOfDay.Select(x => x.Day).Contains(e.Day)))
        .OrderBy(x => x.Day)
        .ToList();

            // thống kê theo ngày lượng đơn hủy

            var orderDespose = queryOrder
            .Where(item => item.Status == false)
                .GroupBy(item => new
                {
                    item.CreatTime.Year,
                    item.CreatTime.Month,
                    item.CreatTime.Day
                })
            .Select(g => new DataOfDay
            {
                Day = g.Key.Day,
                Count = g.Count()
            })
            .ToList();

            orderDespose = orderDespose.Union(
                   selectedDates
                   .Where(e => !orderDespose.Select(x => x.Day).Contains(e.Day)))
                   .OrderBy(x => x.Day)
                   .ToList();

            ViewData["Statistic"] = new DashboardViewModel
            {
                Contact = Contact,
                NewCustomer = NewCustomer,
                OrderDispose = OrderDepose,
                NewOrder = NewOrder,
                StatisticOfDay = new StatisticOfDay
                {
                    newCustomerOfDay = newCustomerOfDay,
                    newOrderOfDay = newOrderOfDay,
                    newContactOfDay = newContactOfDay,
                    orderDespose = orderDespose,

                }
            };

            return View("/Views/Admin/Dashboard/Index.cshtml");

        }


    }

}