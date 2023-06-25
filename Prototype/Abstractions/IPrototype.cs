namespace PrototypePattern.Abstractions
{
    interface IPrototype
    {
        string GetDetails();

        IPrototype Clone();
    }
}
