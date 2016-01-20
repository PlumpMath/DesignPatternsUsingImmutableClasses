using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy
{
    internal class StandardSortStrategy : ISortingStrategy
    {
        public List<int> Sort(IReadOnlyList<int> arrayToSort)
        {
            return arrayToSort.OrderBy(elem => elem).ToList();
        }
    }
}