using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace school.Models
{
    public class Class
    {
        public int id { get; set; }

        [Required]
        [RegularExpression(@"[1-9][A-Z]")]
        [Display(Name = "Class")]
        public string className { get; set; }
    }
}