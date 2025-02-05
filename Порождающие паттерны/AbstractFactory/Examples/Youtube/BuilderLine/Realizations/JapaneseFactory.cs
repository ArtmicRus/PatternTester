using AbstractFactory.Examples.Youtube.BuilderLine.Interfaces;

namespace AbstractFactory.Examples.Youtube.BuilderLine.Realizations
{
    internal class JapaneseFactory : IFactory
    {
        public ICar CreateCar()
        {
            return new JapaneseCar();
        }

        public IEngine CreateEngine()
        {
            return new JapaneseEngine();
        }
    }
}
