using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC5_Day15.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        [DisplayName("Department Name :" )]
        [MinLength(1, ErrorMessage = "Name must be more than 1 Char")]
        [MaxLength(25)]
        [Remote("UniqueName", "Department",AdditionalFields = "DepartmentId", ErrorMessage = "This name is already exists")]
        public string Name { get; set; }
        [MinLength(2, ErrorMessage = "Name must be more than 2 Chars")]
        [MaxLength(25)]
        public string ?Manager { get; set; }

        public List<Student> ?Students { get; set; } 
        public List<Instructore> ?Instructores { get; set; }
        public List<Course> ?Courses { get; set; }

        
    }
}
