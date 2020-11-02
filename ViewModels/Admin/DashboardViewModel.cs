using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace DVN.ViewModels
{
    public class DashboardViewModel
    {

        [Display(Name = "Số khách hàng mới")] 
        public int NewCustomer { get; set; }

        [Display(Name = "Số liên hệ mới")] 
        public int Contact { get; set; }

        [Display(Name = "Số đơn hàng mới")] 
        public int NewOrder { get; set; }

        [Display(Name = "Số đơn hàng hủy bỏ")] 
        public int OrderDispose { get; set; }

        [Display(Name = "Danh sách số liệu theo ngày ")]

        public StatisticOfDay StatisticOfDay {get;set;}

    }
    
    public class StatisticOfDay {
        public List<DataOfDay> newOrderOfDay {get;set;}
        public List<DataOfDay> orderDespose {get;set;}
        public List<DataOfDay> newContactOfDay {get;set;}
        public List<DataOfDay> newCustomerOfDay {get;set;}
    }

    public class DataOfDay {
        public int Day {get;set;}
        public int Count {get;set;}
    }

}