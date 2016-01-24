using System.Collections.Generic;
using System.Linq;
using PatternLibrary.Strategy;
using Toolkit;

namespace Strategy.Strategies
{
    internal class DescendingSortStrategy : ISortingStrategy
    {
        public List<int> Sort(IEnumerable<int> arrayToSort)
        {
            return arrayToSort
                    .OrderByDescending(elem => elem)
                    .ToList();
        }
    }
}