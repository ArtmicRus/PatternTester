using ObserverPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace ObserverPattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class Buyer : IObserver
    {
        private IObservable _product;

        public Buyer(IObservable product)
        {
            _product = product;
            product.AddObserver(this);
        }

        public void Update(double p)
        {
            if (p < 350)
            {
                Console.WriteLine("Покупатель закупил товар по цене " + p);
                _product.RemoveObserver(this);
            }
        }
    }
}
