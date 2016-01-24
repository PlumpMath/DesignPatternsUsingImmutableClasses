using System.Collections.Generic;
using System.Linq;
using PatternLibrary.Strategy;
using Toolkit;

namespace Strategy.Strategies
{
    internal class NotActuallySortedStrategy : ISortingStrategy
    {
        public List<int> Sort(IEnumerable<int> arrayToSort)
        {
            return arrayToSort.ToList();
        }
    }
}