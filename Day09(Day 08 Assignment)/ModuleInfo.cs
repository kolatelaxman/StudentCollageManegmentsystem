
public class ModuleInfo
{
    public string ModuleName;
    public string Description;

    public ModuleInfo(string description, string moduleName)
    {
        Description = description;
        ModuleName = moduleName;
    }

    public void DisplayModule()
    {
        Console.WriteLine($"Module Name : {ModuleName} | Description : {Description}");
    }
}