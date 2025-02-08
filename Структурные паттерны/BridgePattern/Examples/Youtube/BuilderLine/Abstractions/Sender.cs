using BridgePattern.Examples.Youtube.BuilderLine.Interfaces;

namespace BridgePattern.Examples.Youtube.BuilderLine.Abstractions
{
    abstract class Sender
    {
        protected IDataReader _reader;

        protected Sender(IDataReader reader)
        {
            _reader = reader;
        }

        public void SetDataReader(IDataReader dataReader)
        {
            _reader = dataReader;
        }

        public abstract void Send();
    }
}
