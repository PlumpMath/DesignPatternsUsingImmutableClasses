using System.Collections.Generic;
using Toolkit;

namespace PatternLibrary.Strategy
{
    public class Sorter
    {
        private readonly ISortingStrategy _sortingStrategy;

        public Sorter()
        {
        }

        public Sorter(ISortingStrategy sortingStrategy)
        {
            _sortingStrategy = sortingStrategy;
        }

        public Sorter WithSortingStrategy(ISortingStrategy sortingStrategy)
        {
            return new Sorter(sortingStrategy);
        }

        public IReadOnlyList<int> Sort(IEnumerable<int> arrayToSort)
        {
            return _sortingStrategy
                        .Sort(arrayToSort)
                        .DeepClone();
        }
    }
}
