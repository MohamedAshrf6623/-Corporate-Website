namespace MVC5_Day15.ViewModels
{
    public class Deptmsgcolorbranches
    {
        public string Department { get; set; }
        public string Manager { get; set; }
        public string Message { get; set; }
        public string Color { get; set; }
        public List<string> Branches { get; set; } = new List<string>();
    }
}
