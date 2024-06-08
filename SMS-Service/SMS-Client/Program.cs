using StudentContractReference;
using ScholarshipContractReference;
using ScholarshipApplicationReference;

namespace SMS_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, choose one of the three options!");
            Console.WriteLine("1. Student operations");
            Console.WriteLine("2. Scholarship operations");
            Console.WriteLine("3. Application management");

            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    HandleStudentOperations();
                    break;
                case 2:
                    HandleScholarshipOperations();
                    break;
                default:
                    HandleApplicationManagement();
                    break;
            }
        }

        private static void HandleStudentOperations()
        {
            Console.WriteLine("\nYou have successfully chosen student operations!\n");
            Console.WriteLine("Choose one of the student operations: ");
            Console.WriteLine("1. Create");
            Console.WriteLine("2. Update");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. Get all");
            Console.WriteLine("5. Get by ID");

            int studentNumber = int.Parse(Console.ReadLine());
            using (var client = new StudentContractClient())
            {
                switch (studentNumber)
                {
                    case 1:
                        var newStudent = new Student();
                        Console.WriteLine("Enter first name: ");
                        newStudent.FirstName = Console.ReadLine();
                        Console.WriteLine("Enter last name: ");
                        newStudent.LastName = Console.ReadLine();
                        Console.WriteLine("Enter date of birth: ");
                        newStudent.DateOfBirth = Console.ReadLine();
                        Console.WriteLine("Enter email: ");
                        newStudent.Email = Console.ReadLine();
                        Console.WriteLine("Enter GPA: ");
                        newStudent.GPA = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter education: 1. High school 2. University");
                        if(Console.ReadLine() == "1")
                        {
                            newStudent.Education = StudentContractReference.StudentEducation.HighSchool;
                        }
                        else if (Console.ReadLine() == "2")
                        {
                            newStudent.Education = StudentContractReference.StudentEducation.University;
                        }
                        newStudent.IsDeleted = false;
                        Console.WriteLine(newStudent.FirstName);
                        Console.WriteLine(newStudent.Education);
                        Console.WriteLine(newStudent.GPA);
                        client.CreateAsync(newStudent).Wait();
                        Console.WriteLine("Student created successfully.");
                        break;
                    case 2:
                        // Ovde bi trebalo da procitam sve to iz klijenta i azuriram studenta
                        /*var updateStudent = new Student { Initialize properties };*/
                        //client.UpdateAsync(updateStudent);
                        Console.WriteLine("Student updated successfully.");
                        break;
                    case 3:
                        Console.WriteLine("Enter student ID to delete:");
                        int idToDelete = int.Parse(Console.ReadLine());
                        client.DeleteAsync(idToDelete);
                        Console.WriteLine("Student deleted successfully.");
                        break;
                    case 4:
                        var students = client.GetAllAsync();
                        foreach (var student in students.Result)
                        {
                            Console.WriteLine($"ID: {student.ID}, Name: {student.FirstName}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter student ID:");
                        int idToGet = int.Parse(Console.ReadLine());
                        var studentById = client.GetByIdAsync(idToGet);
                        Console.WriteLine($"ID: {studentById.Result.ID}, Name: {studentById.Result.FirstName}");
                        break;
                }
            }
        }

        private static void HandleScholarshipOperations()
        {
            // Similar structure to HandleStudentOperations
        }

        private static void HandleApplicationManagement()
        {
            // Similar structure to HandleStudentOperations
        }
    }
}
