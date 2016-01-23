using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolkit
{
    public static class ListExtensions
    {
        public static string Stringify<T>(this IReadOnlyList<T> list, Func<T, string> printElemFunc = null, string separator = ", ")
        {
            return list.Count > 0 ?
                (printElemFunc != null ? printElemFunc(list.First()) : list.First().ToString())
                + list.Skip(1).Aggregate("", (acc, val) => acc + separator + (printElemFunc != null ? printElemFunc(val) : val.ToString()))
                :
                string.Empty;
        }
    }
}
