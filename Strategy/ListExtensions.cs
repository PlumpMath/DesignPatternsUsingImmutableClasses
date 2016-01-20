using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public static class ListExtensions
    {
        public static string Stringify(this List<int> list)
        {
            return list.Count > 0 ? 
                list.First() + list.Skip(1).Aggregate("", (acc, val) => acc + ", " + val) 
                : 
                string.Empty;
        }

        public static string StringifyOpt(this List<int> list)
        {
            return list.Count <= 0 ? string.Empty :
                list.First() + list.Skip(1)
                            .Aggregate(new StringBuilder(), (acc, v) => acc.Append(" ,").Append(v))
                            .ToString();
        }
    }
}
