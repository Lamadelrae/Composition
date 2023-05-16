namespace Composition.Models;

public class Person
{
    public string Name { get; set; }
    public Job Job { get; set; }

    public Person(string name, Job job)
        => (Name, Job) = (name, job);
}