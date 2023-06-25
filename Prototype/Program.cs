using PrototypePattern;
using PrototypePattern.Abstractions;

IPrototype[] prototypes = { new Circle(10, 1, 2), new Rectangle(10, 20, 3, 4) };

foreach (var prototype in prototypes)
{
    Console.WriteLine(prototype.GetDetails());

    Console.WriteLine(prototype.Clone().GetDetails());
}