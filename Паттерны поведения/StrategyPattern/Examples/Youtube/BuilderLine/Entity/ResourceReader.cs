using StrategyPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace StrategyPattern.Examples.Youtube.BuilderLine.Entity
{
    internal class ResourceReader
    {
        IReader _reader;

        public ResourceReader(IReader reader)
        {
            _reader = reader;
        }

        public void SetStrategy(IReader reader)
        {
            _reader = reader;
        }

        public void Read(string url)
        {
            _reader.Parce(url);
        }
    }

    
}
