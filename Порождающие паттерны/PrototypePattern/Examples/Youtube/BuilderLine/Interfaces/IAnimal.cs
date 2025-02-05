namespace PrototypePattern.Examples.Youtube.BuilderLine.Interfaces
{
    internal interface IAnimal
    {
        void SetName(string name);
        string GetName();
        IAnimal Clone();
    }
}
