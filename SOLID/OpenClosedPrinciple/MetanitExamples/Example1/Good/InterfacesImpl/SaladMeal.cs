using OpenClosedPrinciple.MetanitExamples.Example1.Good.Interfaces;

namespace OpenClosedPrinciple.MetanitExamples.Example1.Good.InterfacesImpl
{
    internal class SaladMeal : IMeal
    {
        public void Make()
        {
            Console.WriteLine("Нарезаем помидоры и огурцы");
            Console.WriteLine("Посыпаем зеленью, солью и специями");
            Console.WriteLine("Поливаем подсолнечным маслом");
            Console.WriteLine("Салат готов");
        }
    }
}
