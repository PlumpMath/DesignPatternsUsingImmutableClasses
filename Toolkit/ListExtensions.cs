using System;
using System.Collections.Generic;
using System.Linq;

namespace Toolkit
{
    public static class ListExtensions
    {
        public static string Stringify<T>(this IReadOnlyCollection<T> list, Func<T, string> printElemFunc = null, string separator = ", ")
        {
            if (list.Count <= 0) return string.Empty;
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
