// See https://aka.ms/new-console-template for more information

Test1();

void Test1()
{
    IModule module = new Module();
    module.AddModule(new ModuleInfo("HTML", "GREAT", 2500, DateTime.Now));
    module.AddModule(new ModuleInfo("PHP", "GREAT", 4500, DateTime.Now));
    module.AddModule(new ModuleInfo("C#", "GREAT", 4500, DateTime.Now));

    IStudent student = new Student();
    student.addStudentRecord(new StudentInfo("laxman", 21, DateTime.Now, Gender.Male));
    student.addStudentRecord(new StudentInfo("salim", 25, DateTime.Now, Gender.Male));

    int choice = 0;
    do
    {
        Console.WriteLine("** College Student Registration **");
        Console.WriteLine("----------------------");
        Console.WriteLine("1. Add Student Record");
        Console.WriteLine("2. Update Student Record");
        Console.WriteLine("3. Get Any Student Record");
        Console.WriteLine("4. Get All Student Record");
        Console.WriteLine("----------------------");
        Console.WriteLine("5. Add Module");
        Console.WriteLine("6. Get any module details");
        Console.WriteLine("7. Get All module details");
        Console.WriteLine("8. Update Module");
        Console.WriteLine("9. Find std marks");
        Console.WriteLine("0. Exit..");
        Console.WriteLine("Enter your choice : ");
        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {

            case 1:
                student.addStudentRecord();
                break;
            case 2:
                student.updateStudent();
                break;
            case 3:
                student.displayAnyStudentRecord();
                break;
            case 4:
                student.displayAllStudentRecord();
                break;
            case 5:
                module.AddModule();
                break;
            case 6:
                module.DisplayAnyModule();
                break;
            case 7:
                module.DisplayAllModule();
                break;
            case 8:
                module.UpdateModule();
                break;
            default:
                if (choice == 0)
                    Environment.Exit(0);
                else
                    Console.WriteLine("Wrong input");
                break;
        }
    } while (choice != 0);
}