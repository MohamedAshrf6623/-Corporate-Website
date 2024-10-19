using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC5_Day15.Models
{
    public class Student
    {
        [Key] public int SSN { get; set; }
        [DisplayName("Student Name :")]
        [MinLength(4 ,ErrorMessage ="Name must be more than 2 Chars")]
        [MaxLength(25)]
        [Remote("UniqueName", "Student",AdditionalFields ="SSN",ErrorMessage ="This name is already exists")]
        [Required] public string Name { get; set; }


        [DisplayName("Student Age :")]
        [Range(20,32 ,ErrorMessage ="The age should be between 20 an 32")]
        public int ? Age { get; set; }


        [DisplayName("Student Address :")]
        [RegularExpression("[a-zA-Z]{4,25}", ErrorMessage ="Address must be in Characters ONLY")]
        public string ? Address { get; set; 
        }
        public string ? image { get; set; }
        [DisplayName("Student Phone Number :")]
        public string ?Phone { get; set; }


        [EmailAddress]
        public string ?EmailAddress { get; set; }
        public int? grade { get; set; }

        [ForeignKey("Department")]
        [DisplayName("Department : ")]
        public int ? DepartmentId { get; set; }
        public Department ?Department { get; set; }
        public List<Course_Result> ?Course_Results { get; set; }
    }
}
