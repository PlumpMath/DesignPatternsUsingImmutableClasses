using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Toolkit;

namespace PatternLibrary.Iterator
{
    public class ImmutableList<T> : IReadOnlyList<T>
        where T : class
    {
        private readonly IReadOnlyList<T> _list;
        public ImmutableList(IEnumerable<T> list)
        {
            _list = list.ToList().DeepClone();
        }

        public T this[int index] => _list[index].DeepClone();

        public int Count => _list.Count;

        public IEnumerator<T> GetEnumerator()
        {
            foreach(var elem in _list)
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
