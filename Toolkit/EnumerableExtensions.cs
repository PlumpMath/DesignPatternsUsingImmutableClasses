using System;
using System.Collections.Generic;
using System.Linq;

namespace Toolkit
{
    public static class EnumerableExtensions
    {
        public static string Stringify<T>(this IEnumerable<T> collection, Func<T, string> printElemFunc = null, string separator = ", ")
        {
            var list = collection.ToList();
            if (!list.Any()) return string.Empty;
            //use sentinel function if none has been provided
            var printFunc = printElemFunc ?? 
                            (elem => elem.ToString());

            var head = printFunc(list.First());
            var tail = list
                .Skip(1)
                .Aggregate("", (acc, val) => acc + separator + printFunc(val));
            return head + tail;
        }
    }
}
