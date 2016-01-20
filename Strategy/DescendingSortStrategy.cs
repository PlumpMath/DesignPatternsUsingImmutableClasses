using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy
{
    internal class DescendingSortStrategy : ISortingStrategy
    {
        public List<int> Sort(IReadOnlyList<int> arrayToSort)
        {
            return arrayToSort.OrderByDescending(elem => elem).ToList();
        }
    }
}