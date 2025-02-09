using ObserverPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace ObserverPattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class Wholesale : IObserver
    {
        private IObservable _product;

        public Wholesale(IObservable product)
        {
            _product = product;
            product.AddObserver(this);
        }

        public void Update(double p)
        {
            if (p < 300)
            {
                Console.WriteLine("Оптовик закупил товар по цене " + p);
                _product.RemoveObserver(this);
            }
        }
    }
}
