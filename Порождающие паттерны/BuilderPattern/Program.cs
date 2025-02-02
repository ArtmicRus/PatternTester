using BuilderPattern.Examples.Metanit.Abstractions;
using BuilderPattern.Examples.Metanit.Entity;
using BuilderPattern.Examples.Metanit.Realizations;
using System.Threading;

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Строитель (Builder) - шаблон проектирования, который инкапсулирует создание объекта
            // и позволяет разделить его на различные этапы.

            // содаем объект пекаря
            Baker baker = new Baker();
            // создаем билдер для ржаного хлеба
            BreadBuilder builder = new RyeBreadBuilder();
            // выпекаем
            Bread ryeBread = baker.Bake(builder);
            Console.WriteLine(ryeBread.ToString());
            // оздаем билдер для пшеничного хлеба
            builder = new WheatBreadBuilder();
            Bread wheatBread = baker.Bake(builder);
            Console.WriteLine(wheatBread.ToString());
        }
    }
}
