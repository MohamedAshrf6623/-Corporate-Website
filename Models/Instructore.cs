using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC5_Day15.Models
{
    public class Instructore
    {
        public int InstructoreId { get; set; }
        [MinLength(4, ErrorMessage = "Name must be more than 2 Chars")]
        [MaxLength(25)]
        [Remote("UniqueName", "Instructore",AdditionalFields = "InstructoreId", ErrorMessage = "This name is already exists")]
        public string Name { get; set; }
        public string? Image { get; set; }
        public double ?Salary { get; set; }
        [DisplayName("instructor Address :")]
        [RegularExpression("[a-zA-Z]{4,25}", ErrorMessage = "Address must be in Characters ONLY")]
        public string? Address { get; set; }
        [EmailAddress]
        public string ?EmailAddress { get; set; }

        [ForeignKey("Department")]
        public int ? DepartmentId { get; set; }
        public Department ?Department { get; set; }

        [ForeignKey("Course")]
        public int? CourseId { get; set; }
        public Course ?Course { get; set; }

       
    }
}
