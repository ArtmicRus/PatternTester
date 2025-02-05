using BuilderPattern.Examples.Metanit.Abstractions;
using BuilderPattern.Examples.Metanit.Entity;
using BuilderPattern.Examples.Metanit.Realizations;
using BuilderPattern.Examples.Youtube.BuilderLine;
using BuilderPattern.Examples.Youtube.BuilderLine.Entity;
using BuilderPattern.Examples.Youtube.BuilderLine.Interfaces;
using BuilderPattern.Examples.Youtube.BuilderLine.Realizations;
using System.Threading;

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Строитель (Builder) - шаблон проектирования, который инкапсулирует создание объекта
            // и позволяет разделить его на различные этапы.

            #region Metanit

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

            #endregion

            #region BuilderLine

            IDeveloper androidDeveloper = new AndroidDeveloper();
            Director director = new Director(androidDeveloper);

            Phone samsung = director.MountFullPhone();
            Console.WriteLine(samsung.AboutPhone());

            IDeveloper IphoneDeveloper = new IphoneDeveloper();
            director.SetDeveloper(IphoneDeveloper);

            Phone iPhone = director.MountOnlyPhone();
            Console.WriteLine(iPhone.AboutPhone());

            #endregion
        }
    }
}
