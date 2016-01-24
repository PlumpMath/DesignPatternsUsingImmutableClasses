using System.Collections;
using System.Collections.Generic;
using Toolkit;

namespace PatternLibrary.Iterator
{
    public class ImmutableList<T> : IReadOnlyList<T>
        where T : class
    {
        IReadOnlyList<T> List;
        public ImmutableList(IReadOnlyList<T> list)
        {
            List = list.DeepClone();
        }

        public T this[int index]
        {
            get
            {
                return List[index].DeepClone();
            }
        }

        public int Count
        {
            get
            {
                return List.Count;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach(var elem in List)
            {
                yield return elem.DeepClone();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
