using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVN.Models
{
    public class Option
    {

        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }

    }

    [NotMapped()]
    public class OptionView
    {
        public float Unitprice { get; set; }
        public float UnitpriceRegister { get; set; }
    }
}