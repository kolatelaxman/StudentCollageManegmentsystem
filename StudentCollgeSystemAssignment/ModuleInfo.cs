// See https://aka.ms/new-console-template for more information
public class ModuleInfo
{
    public string Name;
    public string Discription;
    public double Fees;
    public DateTime DateTime;
    internal string moduleName;
    string s = new string('=', 70);

    public ModuleInfo(string name, string discription, double fees, DateTime dateTime)
    {
        Name = name;
        Discription = discription;
        Fees = fees;
        DateTime = dateTime;
    }

    public void DisplaySingleModule()
    {
        Console.WriteLine(s);
        Console.WriteLine($"|Module Name : {Name} \n Module Description : {Discription} \n Fees : {Fees} \n StartDate : {DateTime} ");
        Console.WriteLine(s);
    }
}