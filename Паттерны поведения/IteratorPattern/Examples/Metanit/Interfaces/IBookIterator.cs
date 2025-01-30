using IteratorPattern.Examples.Metanit.Entities;

namespace IteratorPattern.Examples.Metanit.Interfaces
{
    internal interface IBookIterator
    {
        bool HasNext();
        Book Next();
    }
}
