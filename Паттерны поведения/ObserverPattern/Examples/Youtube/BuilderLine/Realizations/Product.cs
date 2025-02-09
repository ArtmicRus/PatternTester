using ObserverPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace ObserverPattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class Product : IObservable
    {
        private List<IObserver> _observers;
        private double _price;

        public Product(double price)
        {
            _observers = new List<IObserver>();
            _price = price;
        }

        public void ChangePrice(double price)
        {
            _price = price;
            Notify();
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers.ToList())
            {
                observer.Update(_price);
            }
        }
    }
}
