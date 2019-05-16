using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace school.Models
{
    public class Mark
    {
        public int id { get; set; }
        [Required]
        [Range(1,6)]
        public int MarkNumber { get; set; }

        [Required]
        [Display(Name = "Student")]
        public int? StudentId { get; set; }


        [Display(Name = "Student")]
        public Student students
        {
            get
            {

                ApplicationDbContext help = new ApplicationDbContext();
                return help.Students.Where(x => x.id == StudentId).FirstOrDefault();

            }
        }

    }
}