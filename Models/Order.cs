using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVN.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Số điện sử dụng")]
        public float UseValue { get; set; }

        [Display(Name = "Đơn giá")]
        public float UnitPrice { get; set; }

        [Display(Name = "Thành tiền")]
        public float Amount { get; set; }

        [Display(Name = "Trạng thái đơn hàng")]
        public OrderStatus Status { get; set; }
        public int? UserverifyId { get; set; }
        public User Userverify { get; set; }
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        public DateTime CreatTime { get; set; }

    }

    public enum OrderStatus : byte
    {
        Success = 1,
        Dispose = 2,
        Borrowed = 3,
        NoProcess = 4,
        Overdue = 5

    }
}