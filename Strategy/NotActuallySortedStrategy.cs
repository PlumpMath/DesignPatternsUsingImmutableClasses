using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy
{
    internal class NotActuallySortedStrategy : ISortingStrategy
    {
        public List<int> Sort(IReadOnlyList<int> arrayToSort)
        {
            return arrayToSort.ToList();
        }
    }
}