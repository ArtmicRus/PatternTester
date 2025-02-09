using MementoPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace MementoPattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class ExchangeMemento : IMemento
    {
        private int _dollars;
        private int _euro;

        public ExchangeMemento(int dollars, int euro)
        {
            _dollars = dollars;
            _euro = euro;
        }

        public int GetDollars()
        {
            return _dollars;
        }

        public int GetEuro()
        {
            return _euro;
        }
    }
}
