using ProxyPattern.Examples.Metanit.Entity;
using ProxyPattern.Examples.Metanit.Interfaces;
using ProxyPattern.Examples.Metanit.Realizations;

namespace ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Паттерн Заместитель (Proxy) предоставляет объект-заместитель,
            // который управляет доступом к другому объекту.
            // То есть создается объект-суррогат, который может выступать в роли другого объекта и замещать его.

            using (IBook book = new BookStoreProxy())
            {
                // читаем первую страницу
                Page page1 = book.GetPage(1);
                Console.WriteLine(page1.Text);
                // читаем вторую страницу
                Page page2 = book.GetPage(2);
                Console.WriteLine(page2.Text);
                // возвращаемся на первую страницу    
                page1 = book.GetPage(1);
                Console.WriteLine(page1.Text);
            }
        }
    }
}
