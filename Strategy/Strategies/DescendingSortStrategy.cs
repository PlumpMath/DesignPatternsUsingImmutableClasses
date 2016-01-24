using System.Collections.Generic;
using System.Linq;
using PatternLibrary.Strategy;

namespace Strategy.Strategies
{
    internal class DescendingSortStrategy : ISortingStrategy
    {
        public List<int> Sort(IReadOnlyList<int> arrayToSort)
        {
            return arrayToSort.OrderByDescending(elem => elem).ToList();
        }
    }
}