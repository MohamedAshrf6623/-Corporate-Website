namespace MVC5_Day15.ViewModels
{
    public class InstractorCourses
    {
        public string Message { get; set; }
        public string Color { get; set; }
        public string Instructor { get; set; }
        public Double Salary { get; set; }
        public string Address { get; set; }
        public List<string> courses { get; set; } = new List<string>();

    }
}
