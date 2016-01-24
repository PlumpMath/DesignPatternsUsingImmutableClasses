using System.Collections.Generic;

namespace PatternLibrary.Strategy
{
    public interface ISortingStrategy
    {
        List<int> Sort(IEnumerable<int> arrayToSort);
    }
}