using System.Collections.Generic;

namespace PatternLibrary.Strategy
{
    public interface ISortingStrategy
    {
        List<int> Sort(IReadOnlyList<int> arrayToSort);
    }
}