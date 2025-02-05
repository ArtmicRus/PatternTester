using IteratorPattern.Examples.Metanit.Interfaces;

namespace IteratorPattern.Examples.Metanit.Entities
{
    internal class Library : IBookNumerable
    {
        private Book[] books;
        public Library()
        {
            books = new Book[]
            {
                new Book { Name="Война и мир"},
                new Book { Name="Отцы и дети"},
                new Book { Name="Вишневый сад"}
            };
        }
        public int Count
        {
            get { return books.Length; }
        }

        public Book this[int index]
        {
            get { return books[index]; }
        }
        public IBookIterator CreateNumerator()
        {
            return new LibraryNumerator(this);
        }
    }
}
