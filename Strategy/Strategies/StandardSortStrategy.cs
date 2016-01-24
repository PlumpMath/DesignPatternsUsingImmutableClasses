using System.Collections.Generic;
using System.Linq;
using PatternLibrary.Strategy;

namespace Strategy.Strategies
{
    internal class StandardSortStrategy : ISortingStrategy
    {
        public List<int> Sort(IReadOnlyList<int> arrayToSort)
        {
            return arrayToSort.OrderBy(elem => elem).ToList();
        }
    }
}