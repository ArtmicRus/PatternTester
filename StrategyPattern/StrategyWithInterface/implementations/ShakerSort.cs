using StrategyPattern.StrategyWithInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.StrategyWithInterface.implementations
{
    /// <summary>
    /// Сортировка перемешиванием
    /// </summary>
    internal class ShakerSort : ISortStrategy
    {
        public void Sort()
        {
            Console.WriteLine("ShakerSort correct");
        }
    }
}
