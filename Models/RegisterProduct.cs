using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVN.Models
{
    public class RegisterProduct    
    {
        [Key]
        public int Id {get;set;}

        [Display(Name="Công suất")] 
        public float Wattage {get;set;}

        [Display(Name="Đơn giá")]
        public float UnitPrice {get;set;}

        [Display(Name="Thành tiền")]
        public float Amount {get;set;}

        [Display(Name="Trạng thái đơn đăng ký")]
        public RegisterProductStatus Status { get; set; } 
        public int CustomerId {get;set;}

        [ForeignKey("CustomerId")]
        public virtual Customer Customer {get;set;}
        public DateTime CreatTime { get; set; }

    }

    public enum RegisterProductStatus : byte {
        Pendding = 0,
        Abort = 1,
        Success = 2
    }



}