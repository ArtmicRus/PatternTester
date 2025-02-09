using MementoPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace MementoPattern.Examples.Youtube.BuilderLine.Entity
{
    internal class Memory
    {
        private Stack<IMemento> _history;
        private Exchange _exchange;

        public Memory(Exchange exchange)
        {
            _exchange = exchange;
            _history = new Stack<IMemento>();
        }

        public void Backup()
        {
            _history.Push(_exchange.Save());
        }

        public void Undo()
        {
            if (_history.Count == 0)
            {
                return;
            }

            _exchange.Restore(_history.Pop());
        }
    }
}
