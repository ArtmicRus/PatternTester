using StrategyPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace StrategyPattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class SotialNetworkReader : IReader
    {
        public void Parce(string url)
        {
            Console.WriteLine("Парсинг с социальных сетей: " + url);
        }
    }
}
