using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Sorter
    {
        private readonly ISortingStrategy SortingStrategy;

        public Sorter()
        {
        }

        public Sorter(ISortingStrategy sortingStrategy)
        {
            SortingStrategy = sortingStrategy;
        }

        public Sorter WithSortingStrategy(ISortingStrategy sortingStrategy)
        {
            return new Sorter(sortingStrategy);
        }

        public List<int> Sort(IReadOnlyList<int> arrayToSort)
        {
            return SortingStrategy.Sort(arrayToSort);
        }
    }
}
