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
            if (list.Count <= 0)
            {
                return string.Empty;
            }

            return list.First() 
                    + list.Skip(1).Aggregate("", (acc, val) => acc + ", " + val);
        }
    }
}
