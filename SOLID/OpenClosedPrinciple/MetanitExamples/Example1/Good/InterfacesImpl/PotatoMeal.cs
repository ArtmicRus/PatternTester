using OpenClosedPrinciple.MetanitExamples.Example1.Good.Interfaces;

namespace OpenClosedPrinciple.MetanitExamples.Example1.Good.InterfacesImpl
{
    internal class PotatoMeal : IMeal
    {
        public void Make()
        {
            Console.WriteLine("Чистим картошку");
            Console.WriteLine("Ставим почищенную картошку на огонь");
            Console.WriteLine("Сливаем остатки воды, разминаем варенный картофель в пюре");
            Console.WriteLine("Посыпаем пюре специями и зеленью");
            Console.WriteLine("Картофельное пюре готово");
        }
    }
}
