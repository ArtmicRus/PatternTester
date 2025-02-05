namespace AbstractFactory.Examples.Youtube.BuilderLine.Interfaces
{
    internal interface IFactory
    {
        public ICar CreateCar();

        public IEngine CreateEngine();
    }
}
