using IteratorPattern.Examples.Metanit.Entities;

namespace IteratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Паттерн Итератор (Iterator) предоставляет абстрактный интерфейс для последовательного доступа
            // ко всем элементам составного объекта без раскрытия его внутренней структуры.
            Library library = new Library();
            Reader reader = new Reader();
            reader.SeeBooks(library);

            Console.Read();
        }
    }
}
