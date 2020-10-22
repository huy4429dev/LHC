using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace DVN.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Username is not null")]
        [MaxLength(30, ErrorMessage = "Username is too long")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is not null ")]
        [MaxLength(255, ErrorMessage = "The password is not too long")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Email is not null")]
        [MaxLength(100, ErrorMessage = "Invalid email")]
        public string Email { get; set; }
        public string FullName { get; set; }

        [MaxLength(200, ErrorMessage = "The address is not in the correct format")]
        public string Address { get; set; }

        [MaxLength(10, ErrorMessage = "Phone number incorrect format")]
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Status { get; set; }
        public DateTime CreatTime { get; set; }
        public virtual ICollection<New> News {get;set;}

    }

    public enum Gender : byte
    {
        Male,
        FMale,
        BD
    }


}