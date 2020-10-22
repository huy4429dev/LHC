using System.ComponentModel.DataAnnotations;
using System;

namespace DVN.Models
{
    public class CustomerEmail {

        [Key]
        public int Id {get;set;}

        [Required(ErrorMessage="Vui lòng nhập email")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage="Email không đúng định dạng")]
        public string  Email {get;set;}
        public bool Status {get;set;}
        public DateTime CreatedTime {get;set;}

    }
}