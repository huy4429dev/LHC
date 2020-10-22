using System.ComponentModel.DataAnnotations;
using System;

namespace DVN.Models
{
    public class Contact
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Fullnamee Required")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Content Required")]
        public string Content { get; set; }
        [Required(ErrorMessage = "Email Required")]
        public string Email { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedTime { get; set; }

    }
}