using System.Collections.Generic;
using System.Linq;
using PatternLibrary.Strategy;

namespace Strategy.Strategies
{
    internal class NotActuallySortedStrategy : ISortingStrategy
    {
        public List<int> Sort(IReadOnlyList<int> arrayToSort)
        {
            return arrayToSort.ToList();
        }
    }
}