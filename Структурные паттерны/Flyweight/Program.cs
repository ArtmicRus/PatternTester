using Flyweight.Examples.Metanit.Abstractions;
using Flyweight.Examples.Metanit.General;
using Flyweight.Examples.Youtube.BuilderLine.Entity;
using Flyweight.Examples.Youtube.BuilderLine.HelpMethods;
using Flyweight.Examples.Youtube.BuilderLine.Structures;

namespace Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Паттерн Приспособленец (Flyweight) - структурный шаблон проектирования,
            // который позволяет использовать разделяемые объекты сразу в нескольких контекстах.
            // Данный паттерн используется преимущественно для ОПТИМИЗАЦИИ РАБОТЫ С ПАМЯТЬЮ.

            // В качестве стандартного применения данного паттерна можно привести следующий пример.
            // Текст состоит из отдельных символов. Каждый символ может встречаться на одной странице текста много раз.
            // Однако в компьютерной программе было бы слишком накладно выделять память для каждого отдельного символа в тексте.
            // Гораздо проще было бы определить полный набор символов, например,
            // в виде таблицы из 128 знаков (алфавитно-цифровые символы в разных регистрах, знаки препинания и т.д.).
            // А в тексте применить этот набор общих разделяемых символов, вместо сотен и тысяч объектов,
            // которые могли бы использоваться в тексте. И как следствие подобного подхода будет уменьшение
            // количества используемых объектов и уменьшение используемой памяти.

            #region Metanit

            double longitude = 37.61;
            double latitude = 55.74;

            HouseFactory houseFactory = new HouseFactory();
            for (int i = 0; i < 5; i++)
            {
                House panelHouse = houseFactory.GetHouse("Panel");
                if (panelHouse != null)
                    panelHouse.Build(longitude, latitude);
                longitude += 0.1;
                latitude += 0.1;
            }

            for (int i = 0; i < 5; i++)
            {
                House brickHouse = houseFactory.GetHouse("Brick");
                if (brickHouse != null)
                    brickHouse.Build(longitude, latitude);
                longitude += 0.1;
                latitude += 0.1;
            }

            #endregion

            #region BuilderLine

            FlyweightFactory factory = new FlyweightFactory(new List<Shared>()
            {
                new Shared("Microsoft", "Управляющий"),
                new Shared("Google", "Android-разработчик"),
                new Shared("Google", "WEB-разработчик"),
                new Shared("Apple", "IPhone-разработчик"),
            });

            factory.ListFlyweight();
            FlyweightHelper.AddSpecialistDatabase(factory, "Google", "WEB-разработчик", "Борис", "АМ-17234332");
            FlyweightHelper.AddSpecialistDatabase(factory, "Apple", "Управляющий", "Александр", "DE-2211032");

            factory.ListFlyweight();

            #endregion
        }
    }
}
