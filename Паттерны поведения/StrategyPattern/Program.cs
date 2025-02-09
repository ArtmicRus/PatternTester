using StrategyPattern.Examples.Unknown.StrategyWithInterface;
using StrategyPattern.Examples.Unknown.StrategyWithInterface.implementations;
using StrategyPattern.Examples.Youtube.BuilderLine.Entity;
using StrategyPattern.Examples.Youtube.BuilderLine.Realizations;

internal class Program
{
    private static void Main(string[] args)
    {
        // Паттерн Стратегия(Strategy) представляет шаблон проектирования,
        // который определяет набор алгоритмов, инкапсулирует каждый из них и обеспечивает их взаимозаменяемость.
        // В зависимости от ситуации мы можем легко заменить один используемый алгоритм другим.
        // При этом замена алгоритма происходит независимо от объекта, который использует данный алгоритм.

        #region

        PeopleSorter pip = new PeopleSorter(new BubbleSort());
        pip.Sort();

        pip.SortStrategy = new ShakerSort();
        pip.Sort();

        #endregion


        #region BuilderLine

        ResourceReader resourceReader = new ResourceReader(new NewSiteReader());

        string url = "https://news.com";
        resourceReader.Read(url);

        url = "https://facebook.com";
        resourceReader.SetStrategy(new TelegramChannelReader());
        resourceReader.Read(url);

        url = "@news_channel_telegram";
        resourceReader.SetStrategy(new SotialNetworkReader());
        resourceReader.Read(url);

        #endregion
    }
}