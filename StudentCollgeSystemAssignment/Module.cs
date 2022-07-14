// See https://aka.ms/new-console-template for more information

public class Module : IModule
{
    List<ModuleInfo> modules = new List<ModuleInfo>();
    string s = new string('-', 70);


    public void AddModule(ModuleInfo moduleInfo)
    {
        Console.BackgroundColor = ConsoleColor.Red;

        modules.Add(moduleInfo);
    }

    public void AddModule()
    {

        Console.WriteLine("Enter Subject name : ");
        var name = Console.ReadLine();

        Console.WriteLine("Enter Subject Description : ");
        var description = Console.ReadLine();

        Console.WriteLine("Enter Course Fees : ");
        var courseFeesText = Console.ReadLine();

        Console.WriteLine("Enter Startdate : ");
        var startDateText = Console.ReadLine();

        ModuleInfo module = new ModuleInfo(name, description, double.Parse(courseFeesText), DateTime.Parse(startDateText));
        modules.Add(module);
    }

    public void DisplayAllModule()
    {
        Console.WriteLine(s);
        Console.WriteLine("\t\tModule Listing Report");
        Console.WriteLine(s);
        Console.WriteLine("|Name           |Description              |Fees      |Start Date     |");
        Console.WriteLine(s);

        foreach (var module in modules)
        {
            Console.WriteLine($"|{module.Name,-15}|{module.Discription,-25}|{module.Fees,10:N}|{module.DateTime,-15:dd-MMM-yyyy}|");
        }

        Console.WriteLine(s);
    }

    public void DisplayAnyModule()
    {
        Console.WriteLine(s);
        Console.Write("Enter module name to search : ");
        string searchModule = Console.ReadLine();

        foreach (var module in modules)
        {
            if (searchModule == module.Name)
            {
                module.DisplaySingleModule();
            }
        }
        Console.WriteLine(s);

    }

    public void findStudentMarks() //Find student mark is not Working
    {
       Console.WriteLine(s);
       var subjectSearchText = Console.ReadLine();
        foreach(var subject in modules)
        {
            if (Student.name == subjectSearchText)
            {
                Console.WriteLine("Student Total Marks:" + Student.TotalMarks);
                break;
            }
            else
                Console.WriteLine("Wrong Inpute");
        }
        Console.WriteLine(s);

    }



    public void UpdateModule()
    {
        Console.WriteLine(s);
        Console.WriteLine("Search name of the record you want to update : ");
        string updateName = Console.ReadLine();

        foreach (var module in modules)

        {

            if (updateName == module.Name)
            {

                Console.Write($"What you want to update in {updateName}'s record. \n 1. Subject Name \n 2.Description \n 3.Course \n 4.Start date");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Subject name : ");
                        var Sname = Console.ReadLine();
                        module.moduleName = Sname;
                        Console.WriteLine("Name updated successfully");
                        break;

                    case 2:
                        Console.Write("Enter Description : ");
                        var Sage = Console.ReadLine();
                        module.moduleName = Sage;
                        Console.WriteLine("Desciption updated successfully");
                        break;

                    case 3:
                        Console.Write("Enter Course : ");
                        var Sdob = Console.ReadLine();
                        module.moduleName = Sdob;
                        Console.WriteLine("Courese updated successfully");
                        break;

                    case 4:
                        Console.Write("Enter Start date : ");
                        var Sgender = Console.ReadLine();
                        module.moduleName = Sgender;
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

