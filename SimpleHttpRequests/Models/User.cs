namespace SimpleHttpRequests.Models
{
    public class User
    {
        public string Name { get; set; }
        public bool IsStudent { get; set; }
        public int Age { get; set; }
        public double MonthlySalary { get; set; }
        public char[] SuccessSymbols { get; set; }
        public Person Parent { get; set; }
        public Person[] Children { get; set; }
    }
}
