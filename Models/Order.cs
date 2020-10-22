using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVN.Models
{
    public class Order
    {
        [Key]
        public int Id {get;set;}

        [Display(Name="Số điện sử dụng")]     
        public float UseValue {get;set;}

        [Display(Name="Đơn giá")]
        public float UnitPrice {get;set;}

        [Display(Name="Thành tiền")]
        public float Amount {get;set;}

        [Display(Name="Trạng thái đơn hàng")]
        public bool Status { get; set; } 
        public int CustomerId {get;set;}

        [ForeignKey("CustomerId")]
        public virtual Customer Customer {get;set;}
        public DateTime CreatTime { get; set; }

    }


}