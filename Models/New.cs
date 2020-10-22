using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVN.Models
{
    public class New
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Thumbnail Required")]
        public string Thumbnail { get; set; }
        [Required(ErrorMessage = "Description Required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Content Required")]
        public string Content { get; set; }
        [Required(ErrorMessage = "Email Required")]
        public bool Status { get; set; }
        public int UserId {get;set;}
        
        [ForeignKey("UserId")]
        public virtual User User {get;set;}
        public DateTime CreatedTime { get; set; }

    }
}