namespace Composition.Models;

public class Person : IDisposable
{
    private bool _disposed;

    public string Name { get; set; }
    public List<Organ> Organs { get; set; }

    public Person(string name)
    {
        Name = name;
        Organs = new List<Organ>()
        {
            new Organ(name: "Heart"),
            new Organ(name: "Kidney"),
            new Organ(name: "Lungs"),
            new Organ(name: "Bladder"),
        };
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    private void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                Name = null;
                Organs = null;
                GC.Collect();
            }

            _disposed = true;
        }
    }
}