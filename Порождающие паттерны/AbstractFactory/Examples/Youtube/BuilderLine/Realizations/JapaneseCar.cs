using AbstractFactory.Examples.Youtube.BuilderLine.Interfaces;

namespace AbstractFactory.Examples.Youtube.BuilderLine.Realizations
{
    internal class JapaneseCar : ICar
    {
        public void ReleaseCar(IEngine engine)
        {
            Console.WriteLine("Собрали японский автомобиль: ");
            engine.ReleaseEngine();
        }
    }
}
