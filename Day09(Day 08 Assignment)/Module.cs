using Day08;

public class Module : IModule
{
    List<ModuleInfo> modules = new List<ModuleInfo>();

    public void AddModule(ModuleInfo moduleInfo)
    {
        modules.Add(moduleInfo);
    }

    public void AddModule()
    {
        Console.WriteLine("Enter Module Name : ");
        var modulename = Console.ReadLine();

        Console.WriteLine("Enter Description : ");
        var description = Console.ReadLine();

        ModuleInfo module = new ModuleInfo(modulename, description);
        modules.Add(module);

    }

    public void DisplayAllModuleInfo()
    {
        foreach (var module in modules)
        {
            Console.WriteLine($"|{module.ModuleName}|{module.Description}|");
        }
    }

    public void DisplayAnyModuleInfo()
    {
        throw new NotImplementedException();
    }

    public void UpdateModule()
    {
        throw new NotImplementedException();
    }
}