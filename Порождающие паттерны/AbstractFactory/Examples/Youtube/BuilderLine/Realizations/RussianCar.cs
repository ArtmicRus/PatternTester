using AbstractFactory.Examples.Youtube.BuilderLine.Interfaces;

namespace AbstractFactory.Examples.Youtube.BuilderLine.Realizations
{
    internal class RussianCar : ICar
    {
        public void ReleaseCar(IEngine engine)
        {
            Console.WriteLine("Собрали русский автомобиль: ");
            engine.ReleaseEngine();
        }
    }
}
