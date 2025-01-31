using VisitorPattern.Examples.Metanit.Entity;
using VisitorPattern.Examples.Metanit.Realizations;

namespace VisitorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Паттерн Посетитель (Visitor) позволяет определить операцию для объектов других классов
            // без изменения этих классов.

            // При использовании паттерна Посетитель определяются две иерархии классов:
            // одна для элементов, для которых надо определить новую операцию,
            // и вторая иерархия для посетителей, описывающих данную операцию.

            var structure = new Bank();
            structure.Add(new Person { Name = "Иван Алексеев", Number = "82184931" });
            structure.Add(new Company { Name = "Microsoft", RegNumber = "ewuir32141324", Number = "3424131445" });
            structure.Accept(new HtmlVisitor());
            structure.Accept(new XmlVisitor());
        }
    }
}
