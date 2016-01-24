using System.Collections.Generic;

namespace PatternLibrary.Strategy
{
    public class Sorter
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
