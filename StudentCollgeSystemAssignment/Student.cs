// See https://aka.ms/new-console-template for more information


public enum Gender
{
    Male,
    Female
}

public class Student : IStudent
{
    internal static string name;
    List<StudentInfo> students = new List<StudentInfo>();
    string s = new string('=', 55);

    string StudentName;
    int Age;
    DateTime DateOfBirth;
    Gender Gender;

    public static string TotalMarks { get; internal set; }

    public void addStudentRecord(StudentInfo studentInfo)
    {
        students.Add(studentInfo);
    }

    public void addStudentRecord()
    {
        //var studentId = 101;

        Gender gender;

        Console.Write("\nEnter Student name : ");
        string studentName = Console.ReadLine();

        Console.Write("\nEnter Age : ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("\nEnter Date of Birth : ");
        var dateOfBirth = Console.ReadLine();

        Console.Write("\nEnter Gender : ");
        var genderText = Console.ReadLine();

        gender = (Gender)Enum.Parse(typeof(Gender), genderText);

        StudentInfo student = new StudentInfo(studentName, age, DateTime.Parse(dateOfBirth), gender);
        students.Add(student);

    }

    public void displayAllStudentRecord()
    {
        Console.WriteLine(s);
        Console.WriteLine("\t\tStudent Listing Report");
        Console.WriteLine(s);
        Console.WriteLine("|Name           |Age       |DateOfBirth    |Gender    |");
        Console.WriteLine(s);

        foreach (var student in students)
        {
            Console.WriteLine($"|{student.StudentName,-15}|{student.Age,-10}|{student.DateOfBirth,-10:dd-MMM-yyyy}    |{student.Gender,-10}|    ");
        }
        Console.WriteLine(s);

    }

    public void displayAnyStudentRecord()
    {
        Console.Write("Enter Name or Roll No to find : ");
        string studentFoundText = Console.ReadLine();

        foreach (var student in students)
        {

            if (studentFoundText == student.StudentName)
            {
                student.Display();

            }
        }
    }

    public void findStudentMarks()
    {
        throw new NotImplementedException();
    }

    public void updateStudent()
    {
        Console.WriteLine(s);
        Console.WriteLine("Search name of the record you want to update : ");
        string updateName = Console.ReadLine();

        foreach (var student in students)
        {

            if (updateName == student.StudentName)
            {

                Console.Write($"What you want to update in {updateName}'s record. \n 1.Name \n 2.Age \n 3.DateOfBirth \n 4.Gender");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter name : ");
                        var Sname = Console.ReadLine();
                        student.StudentName = Sname;
                        Console.WriteLine("Name updated successfully");
                        break;

                    case 2:
                        Console.Write("Enter Age : ");
                        var Sage = Console.ReadLine();
                        student.StudentName = Sage;
                        Console.WriteLine("Age updated successfully");
                        break;

                    case 3:
                        Console.Write("Enter Date of Birth : ");
                        var Sdob = Console.ReadLine();
                        student.StudentName = Sdob;
                        Console.WriteLine("Date of Birth updated successfully");
                        break;

                    case 4:
                        Console.Write("Enter Gender : ");
                        var Sgender = Console.ReadLine();
                        student.StudentName = Sgender;
                        Console.WriteLine("Gender updated successfully");
                        break;

                    default:
                        if (choice == 0)
                            Environment.Exit(0);
                        break;
                }

            }
        }


        Console.WriteLine(s);
    }
}