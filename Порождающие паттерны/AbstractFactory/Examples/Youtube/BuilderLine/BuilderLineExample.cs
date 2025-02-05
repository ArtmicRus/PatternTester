using AbstractFactory.Examples.Youtube.BuilderLine.Interfaces;
using AbstractFactory.Examples.Youtube.BuilderLine.Realizations;

namespace AbstractFactory.Examples.Youtube.BuilderLine
{
    internal class BuilderLineExample
    {
        static public void Example()
        {
            IFactory factory = new JapaneseFactory();
            ICar car = factory.CreateCar();
            IEngine engine = factory.CreateEngine();

            car.ReleaseCar(engine);

            IFactory factory2 = new RussianFactory();
            ICar car2 = factory.CreateCar();
            IEngine engine2 = factory.CreateEngine();

            car2.ReleaseCar(engine2);
        }
    }
}
