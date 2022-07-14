// See https://aka.ms/new-console-template for more information
public interface IModule
{
    public void AddModule(ModuleInfo moduleInfo);
    public void AddModule();
    public void DisplayAnyModule();
    public void DisplayAllModule();
    public void UpdateModule();
}