using StrategyPattern.Examples.Unknown.StrategyWithInterface.Interfaces;

namespace StrategyPattern.Examples.Unknown.StrategyWithInterface
{
    /// <summary>
    /// Объект человека занимающегося сортировкой
    /// </summary>
    internal class PeopleSorter
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="sortStrategy">Стратегия сортировки</param>
        public PeopleSorter(ISortStrategy sortStrategy)
        {
            SortStrategy = sortStrategy;
        }

        /// <summary>
        /// Обёртка вызова сортировки из самого объекта
        /// </summary>
        /// <remarks>
        /// Можно обойтись без обёртки тогда нужно к методу поля SortStrategy объекта
        /// </remarks>
        public void Sort()
        {
            SortStrategy.Sort();
        }

        public ISortStrategy SortStrategy { get; set; }
    }
}
