using ProxyPattern.Examples.Metanit.Entity;
using ProxyPattern.Examples.Metanit.Interfaces;
using ProxyPattern.Examples.Metanit.Realizations;
using ProxyPattern.Examples.Youtube.BuilderLine.Interfaces;
using ProxyPattern.Examples.Youtube.BuilderLine.Realizations;

namespace ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Паттерн Заместитель (Proxy) предоставляет объект-заместитель,
            // который управляет доступом к другому объекту.
            // То есть создается объект-суррогат, который может выступать в роли другого объекта и замещать его.

            #region Metanit (не рабочий)

            //using (IBook book = new BookStoreProxy())
            //{
            //    // читаем первую страницу
            //    Page page1 = book.GetPage(1);
            //    Console.WriteLine(page1.Text);
            //    // читаем вторую страницу
            //    Page page2 = book.GetPage(2);
            //    Console.WriteLine(page2.Text);
            //    // возвращаемся на первую страницу    
            //    page1 = book.GetPage(1);
            //    Console.WriteLine(page1.Text);
            //}

            #endregion

            #region BuilderLine

            ISite mySite = new SiteProxy(new Site());

            Console.WriteLine(mySite.GetPage(1));
            Console.WriteLine(mySite.GetPage(2));
            Console.WriteLine(mySite.GetPage(3));

            Console.WriteLine(mySite.GetPage(2));

            #endregion
        }
    }
}
