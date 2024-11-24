namespace OpenClosedPrinciple.MetanitExamples.Example1.Bad
{
    internal class BadCook
    {
        public string Name { get; set; }
        public BadCook(string name)
        {
            Name = name;
        }

        public void MakeDinner()
        {
            Console.WriteLine("Чистим картошку");
            Console.WriteLine("Ставим почищенную картошку на огонь");
            Console.WriteLine("Сливаем остатки воды, разминаем варенный картофель в пюре");
            Console.WriteLine("Посыпаем пюре специями и зеленью");
            Console.WriteLine("Картофельное пюре готово");
        }
    }
}
