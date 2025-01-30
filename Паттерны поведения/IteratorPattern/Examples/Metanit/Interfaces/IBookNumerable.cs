using IteratorPattern.Examples.Metanit.Entities;

namespace IteratorPattern.Examples.Metanit.Interfaces
{
    internal interface IBookNumerable
    {
        IBookIterator CreateNumerator();
        int Count { get; }
        Book this[int index] { get; }
    }
}
