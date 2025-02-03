using FactoryPattern.Examples.Metanit.Abstractions;

namespace FactoryPattern.Examples.Metanit.Realizations
{
    class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Деревянный дом построен");
        }
    }
}
