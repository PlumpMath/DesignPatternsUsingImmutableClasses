using System.Collections.Generic;

namespace Strategy
{
    internal interface ISortingStrategy
    {
        List<int> Sort(IReadOnlyList<int> arrayToSort);
    }
}