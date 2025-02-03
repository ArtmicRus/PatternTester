using FactoryPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace FactoryPattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class CarWorkShop : IWorkShop
    {
        public IProduction Create()
        {
            return new Car();
        }
    }
}
