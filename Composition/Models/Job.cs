namespace Composition.Models;

public class Job
{
    public string Name { get; set; }
    public Job(string name) => Name = name;
}