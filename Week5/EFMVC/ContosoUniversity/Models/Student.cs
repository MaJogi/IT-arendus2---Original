using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {   public int ID { get; set; }
        [Required]
        //[StringLength(50, MinimumLength=1)] in this case need isn't needed
        [StringLength(50)] //Client side + server side validation, MaxLength provides only server side validation
        [Display(Name = "Last Name")]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")] // First will be uppercase and else should be alphabetical
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Full Name")] //The caption, without it it would be property name
        public string FullName
        {
            get { return LastName + ", " + FirstMidName; }
        }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
