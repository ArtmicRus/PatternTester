using FactoryPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace FactoryPattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class TruckWorkShop : IWorkShop
    {
        public IProduction Create()
        {
            return new Truck();
        }
    }
}
