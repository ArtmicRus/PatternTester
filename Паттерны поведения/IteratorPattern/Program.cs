using IteratorPattern.Examples.Metanit.Entities;
using IteratorPattern.Examples.Youtube.BuilderLine.Entity;

namespace IteratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Паттерн Итератор (Iterator) предоставляет абстрактный интерфейс для последовательного доступа
            // ко всем элементам составного объекта без раскрытия его внутренней структуры.

            #region Unknown

            Library library = new Library();
            Reader reader = new Reader();
            reader.SeeBooks(library);

            #endregion

            #region BuilderLine

            DataStack stack1 = new DataStack();

            for (int i = 1; i < 5; i++)
            {
                stack1.Push(i);
            }

            DataStack stack2 = new DataStack(stack1);

            Console.WriteLine(stack1 == stack2);

            stack2.Push(10);

            Console.WriteLine(stack1 == stack2);

            #endregion
        }
    }
}
