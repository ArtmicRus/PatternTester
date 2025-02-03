using FactoryPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace FactoryPattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class Car : IProduction
    {
        public void Realise()
        {
            Console.WriteLine("Выпущен новый легковой автомобиль");
        }
    }
}
