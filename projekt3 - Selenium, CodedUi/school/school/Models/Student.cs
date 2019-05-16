using school.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace school.Models
{
    public class Student
    {
        public int id { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [IsPesel]
        [Display(Name = "Pesel")]
        public string Pesel { get; set; }

        [Required]
        [Display(Name = "Class")]
        public int? ClassId { get; set; }


        [Display(Name = "Class")]
        public Class classes
        {
            get
            {

                ApplicationDbContext help = new ApplicationDbContext();
                return help.Classes.Where(x => x.id == ClassId).FirstOrDefault();

            }
        }



    }
}