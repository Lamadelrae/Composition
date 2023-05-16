using Composition.Models;

var job = new Job("Software Engineer");
var person = new Person("Matthew", job);

Console.WriteLine($"My name is {person.Name} and I am a {person.Job.Name}.");