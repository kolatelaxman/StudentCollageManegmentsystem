// See https://aka.ms/new-console-template for more information


public class StudentInfo
{
    public string StudentName;
    public int Age;
    public DateTime DateOfBirth;
    public Gender Gender;

    string s = new string('=', 70);
    
    public StudentInfo(string studentName, int age, DateTime dateOfBirth, Gender gender)
    {
        StudentName = studentName;
        Age = age;
        DateOfBirth = dateOfBirth;
        Gender = gender;

        Console.WriteLine("Innserted Succeessfully");
        string s = new string('=', 30);
        Console.WriteLine(s);
    }

    public void Display()
    {
        Console.WriteLine(s);
        Console.WriteLine($"Student Name : {StudentName} \n Student Age : {Age} \n Student Date Of Birth : {DateOfBirth} \n Gender : {Gender}");
        Console.WriteLine(s);
    }
}