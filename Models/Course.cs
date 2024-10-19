using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC5_Day15.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [MinLength(2, ErrorMessage = "Name must be more than 2 Chars")]
        [MaxLength(25)]
        [Remote("UniqueName", "Course", AdditionalFields = "CourseId", ErrorMessage = "This name is already exists")]
        public string Name { get; set; }
        [DisplayName("Max_Degree")]
        public int? Degree { get; set; }
        public int? Min_Degree {get; set ;}

        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }
        public Department ? Department { get; set; }
        public List<Instructore> ?Instructores { get; set; }
        public List<Course_Result> ?Course_Results { get; set; }
    }
}
