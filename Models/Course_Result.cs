using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC5_Day15.Models
{
    public class Course_Result
    {
        public int Course_ResultId { get; set; }
      
        [Remote("DegreeLimit","Course_Result",ErrorMessage ="The entered Degree should be between 0 and 300")]
        public int? Degree { get; set; }

        [ForeignKey("Course")]
        public int ? CourseId { get; set; }
        public Course ?Course { get; set; }

        [ForeignKey("Student")]
        public int? SSN { get; set; }
        public Student ?Student { get; set; }
    }
}
