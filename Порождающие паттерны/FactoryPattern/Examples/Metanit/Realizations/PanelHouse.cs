using FactoryPattern.Examples.Metanit.Abstractions;

namespace FactoryPattern.Examples.Metanit.Realizations
{
    class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Панельный дом построен");
        }
    }
}
