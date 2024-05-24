Console.WriteLine("Hello, choose one of the three options!");
Console.WriteLine("1. Student operations");
Console.WriteLine("2. Scholarship operations");
Console.WriteLine("3. Application management");

int number = int.Parse(Console.ReadLine());
switch (number)
{
    case 1:
        Console.WriteLine("\nYou have successfully chosen student operations!\n");
        Console.WriteLine("Choose one of the student operations: ");
        Console.WriteLine("1. Create");
        Console.WriteLine("2. Update");
        Console.WriteLine("3. Delete");
        Console.WriteLine("4. Get all");
        Console.WriteLine("5. Get by ID");

        int studentNumber = int.Parse(Console.ReadLine());
        switch (studentNumber)
        {
            case 1:

                break;
            case 2:

                break;            
            case 3:

                break;            
            case 4:

                break;            
            case 5:

                break;
        }  
        break;
    case 2:
        Console.WriteLine("\nYou have successfully chosen scholarship operations!\n");
        Console.WriteLine("Choose one of the scholarship operations: ");
        Console.WriteLine("1. Create");
        Console.WriteLine("2. Update");
        Console.WriteLine("3. Delete");
        Console.WriteLine("4. Get all");
        Console.WriteLine("5. Get by ID");

        int scholarshipNumber = int.Parse(Console.ReadLine());
        switch (scholarshipNumber)
        {
            case 1:

                break;
            case 2:

                break;
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
        }
        break;
    default:
        Console.WriteLine("\nYou have successfully chosen application management!\n");
        Console.WriteLine("Choose one of the appliaction management operations: ");
        Console.WriteLine("1. Apply for scholarship");
        Console.WriteLine("2. Check application status");
        Console.WriteLine("3. Get pending");
        Console.WriteLine("4. Accept Scholarship Application");
        Console.WriteLine("5. Reject Scholarship Application");

        int applicationNumber = int.Parse(Console.ReadLine());
        switch (applicationNumber)
        {
            case 1:

                break;
            case 2:

                break;
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
        }
        break;

}