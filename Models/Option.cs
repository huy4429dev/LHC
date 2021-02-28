using System.ComponentModel.DataAnnotations;
using System;

namespace DVN.Models
{
    public class Option {

        [Key]
        public int Id {get;set;}
        public string  Type {get;set;}
        public string  Value {get;set;}
        public DateTime CreatedTime {get;set;}
        public DateTime UpdatedTime {get;set;}

    }
}