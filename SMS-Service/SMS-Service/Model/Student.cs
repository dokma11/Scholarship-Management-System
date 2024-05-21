namespace SMS_Service.Model
{
    public class Student
    {
        private int StudentID { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Email { get; set; }
        private string DateOfBirth { get; set; }
        private Education education { get; set; }
        private double GPA { get; set; }
    }


    public enum Education
    {
        HighSchool,
        University
    }
}
