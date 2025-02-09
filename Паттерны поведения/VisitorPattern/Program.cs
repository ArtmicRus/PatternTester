using VisitorPattern.Examples.Metanit.Entity;
using VisitorPattern.Examples.Metanit.Interfaces;
using VisitorPattern.Examples.Metanit.Realizations;
using VisitorPattern.Examples.Youtube.BuilderLine.Interfaces;
using VisitorPattern.Examples.Youtube.BuilderLine.Realizations;

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

            #region

            var structure = new Bank();
            structure.Add(new Person { Name = "Иван Алексеев", Number = "82184931" });
            structure.Add(new Company { Name = "Microsoft", RegNumber = "ewuir32141324", Number = "3424131445" });
            structure.Accept(new HtmlVisitor());
            structure.Accept(new XmlVisitor());

            #endregion

            #region BuilderLine

            Console.WriteLine();

            List<IPlace> places = new List<IPlace>() { new Zoo(), new Cinema(), new Circus() };

            foreach (var place in places)
            {
                HolydayMarket visitor = new HolydayMarket();
                place.Accept(visitor);
                Console.WriteLine(visitor.value);
            }

            #endregion
        }
    }
}
