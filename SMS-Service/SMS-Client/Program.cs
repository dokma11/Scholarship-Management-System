using StudentContractService;

namespace SMS_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nHello, choose one of the three options!");
                Console.WriteLine("1. Student operations");
                Console.WriteLine("2. Scholarship operations");
                Console.WriteLine("3. Application management");
                Console.WriteLine("4. Exit");

                int number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        HandleStudentOperations();
                        break;
                    case 2:
                        HandleScholarshipOperations();
                        break;
                    case 3:
                        HandleApplicationManagement();
                        break;
                    case 4:
                        Console.WriteLine("Client is closing...");
                        running = false;
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
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
            Console.WriteLine("6. Exit");

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
                        if (Console.ReadLine() == "1")
                        {
                            newStudent.Education = StudentContractService.StudentEducation.HighSchool;
                        }
                        else if (Console.ReadLine() == "2")
                        {
                            newStudent.Education = StudentContractService.StudentEducation.University;
                        }
                        newStudent.IsDeleted = false;
                        client.CreateAsync(newStudent).Wait();
                        Console.WriteLine("Student created successfully.");
                        break;
                    case 2:
                        var updateStudent = new Student();
                        Console.WriteLine("Enter id of student that you want to update");
                        updateStudent.ID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter first name: ");
                        updateStudent.FirstName = Console.ReadLine();
                        Console.WriteLine("Enter last name: ");
                        updateStudent.LastName = Console.ReadLine();
                        Console.WriteLine("Enter date of birth: ");
                        updateStudent.DateOfBirth = Console.ReadLine();
                        Console.WriteLine("Enter email: ");
                        updateStudent.Email = Console.ReadLine();
                        Console.WriteLine("Enter GPA: ");
                        updateStudent.GPA = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter education: 1. High school 2. University");
                        if (Console.ReadLine() == "1")
                        {
                            updateStudent.Education = StudentContractService.StudentEducation.HighSchool;
                        }
                        else if (Console.ReadLine() == "2")
                        {
                            updateStudent.Education = StudentContractService.StudentEducation.University;
                        }                        
                        client.UpdateAsync(updateStudent).Wait();
                        Console.WriteLine("Student updated successfully.");
                        break;
                    case 3:
                        Console.WriteLine("Enter student ID to delete:");
                        int idToDelete = int.Parse(Console.ReadLine());
                        client.DeleteAsync(idToDelete).Wait();
                        Console.WriteLine("Student deleted successfully.");
                        break;
                    case 4:
                        var students = client.GetAllAsync();
                        foreach (var student in students.Result)
                        {
                            Console.WriteLine($"ID: {student.ID}, Name: {student.FirstName}, Surname: {student.LastName}, GPA: {student.GPA}, " +
                                $"Email: {student.Email}, Date of birth: {student.DateOfBirth}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter student ID:");
                        int idToGet = int.Parse(Console.ReadLine());
                        var studentById = client.GetByIdAsync(idToGet);
                        Console.WriteLine($"ID: {studentById.Result.ID}, Name: {studentById.Result.FirstName}, Surname: {studentById.Result.LastName}, " +
                            $"GPA: {studentById.Result.GPA}, Email: {studentById.Result.Email}, Date of birth: {studentById.Result.DateOfBirth}"); 
                        break;
                    case 6:
                        Console.WriteLine("Client is closing...");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
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
