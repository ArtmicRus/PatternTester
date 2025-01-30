using IteratorPattern.Examples.Metanit.Interfaces;

namespace IteratorPattern.Examples.Metanit.Entities
{
    internal class Reader
    {
        public void SeeBooks(Library library)
        {
            IBookIterator iterator = library.CreateNumerator();
            while (iterator.HasNext())
            {
                Book book = iterator.Next();
                Console.WriteLine(book.Name);
            }
        }
    }
}
