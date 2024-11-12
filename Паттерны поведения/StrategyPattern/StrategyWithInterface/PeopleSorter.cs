using StrategyPattern.StrategyWithInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.StrategyWithInterface
{
    /// <summary>
    /// Объект человека занимающегося сортировкой
    /// </summary>
    internal class PeopleSorter
    {
        public PeopleSorter(ISortStrategy sortStrategy)
        {
            SortStrategy = sortStrategy;
        }

        public void Sort()
        {
            SortStrategy.Sort();
        }

        public ISortStrategy SortStrategy { get; set; }
    }
}
