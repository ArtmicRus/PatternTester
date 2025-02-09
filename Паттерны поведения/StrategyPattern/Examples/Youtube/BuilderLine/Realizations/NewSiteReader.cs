using StrategyPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace StrategyPattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class NewSiteReader : IReader
    {
        public void Parce(string url)
        {
            Console.WriteLine("Парсинг с новостного сайта: " + url);
        }
    }
}
