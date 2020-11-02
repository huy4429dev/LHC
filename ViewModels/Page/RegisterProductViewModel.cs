using System.ComponentModel.DataAnnotations;

namespace DVN.ViewModels
{
    public class RegisterProductViewModel
    {

        [Required(ErrorMessage = "Công suất không được bỏ trống")]
        [RegularExpression(@"\d+", ErrorMessage = "Công suất không đúng định dạng")]
        [Display(Name = "Công suất")]
        public float Wattage { get; set; }

        [Display(Name = "Đơn giá")]
        public float UnitPrice { get; set; }

        [Display(Name = "Thành tiền")]
        public float Amount { get; set; }
        
        [Display(Name = "Diện tích mái lắp đặt")]
        public float Roof { get; set; }

        [Display(Name = "Vị trí lắp đặt")]
        public string Place { get; set; }

        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Họ không được bỏ trống")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Tên không được bỏ trống")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được bỏ trống")]
        [RegularExpression(@"\d{10}", ErrorMessage = "Số điện thoại không đúng định dạng")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email không được bỏ trống")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email không đúng định dạng")]
        [MaxLength(100, ErrorMessage = "Email không đúng định dạng")]
        public string Email { get; set; }

    }
}