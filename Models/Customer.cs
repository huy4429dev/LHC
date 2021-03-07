using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVN.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(30, ErrorMessage = "Tên đăng nhập không đúng định dạng")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Mật khẩu không được bỏ trống ")]
        [MaxLength(255, ErrorMessage = "Mật khẩu không đúng định dạng")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Vui lòng xác nhận lại mật khẩu")]
        [StringLength(255, ErrorMessage = "Mật khẩu phải lớn hơn 5 kí tự", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "Mật khẩu không khớp")]
        [NotMapped]
        public string ConfirmPassword { get; set; }
        public string FullName { get; set; }
        public string BankName { get; set; }
        public string BankNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityCard { get; set; }

        [Required(ErrorMessage = "Email không được bỏ trống")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email không đúng định dạng")]
        [MaxLength(100, ErrorMessage = "Email không đúng định dạng")]
        public string Email { get; set; }
        public Gender Gender { get; set; }

        [MaxLength(200, ErrorMessage = "Địa chỉ không đúng định dạng")]
        public string Address { get; set; }

        [MaxLength(10, ErrorMessage = "Số điện thoại không đúng định dạng")]
        public string Phone { get; set; }

        public DateTime BirthDate { get; set; }
        public bool Status { get; set; }
        public DateTime CreatTime { get; set; }

        public virtual ICollection<RegisterProduct> RegisterProducts { get; set; }

    }



}