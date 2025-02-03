using FactoryPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace FactoryPattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class Truck : IProduction
    {
        public void Realise()
        {
            Console.WriteLine("Выпущен новый грузовой автомобиль");
        }
    }
}
