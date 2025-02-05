using AbstractFactory.Examples.Youtube.BuilderLine.Interfaces;

namespace AbstractFactory.Examples.Youtube.BuilderLine.Realizations
{
    internal class RussianFactory : IFactory
    {
        public ICar CreateCar()
        {
            return new RussianCar();
        }

        public IEngine CreateEngine()
        {
            return new RussianEngine();
        }
    }
}
