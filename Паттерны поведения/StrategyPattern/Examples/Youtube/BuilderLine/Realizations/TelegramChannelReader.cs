using StrategyPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace StrategyPattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class TelegramChannelReader : IReader
    {
        public void Parce(string url)
        {
            Console.WriteLine("Парсинг с телеграма: " + url);
        }
    }
}
