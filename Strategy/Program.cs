using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolkit;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IReadOnlyList<int> listToSort = new List<int>() { 1, 3, 5, 4, 3, 3, 19};
            var sorter = new Sorter();

            var sorted = sorter
                        .WithSortingStrategy(new StandardSortStrategy())
                        .Sort(listToSort);
            Console.WriteLine(sorted.Stringify());

            sorted = sorter
                        .WithSortingStrategy(new DescendingSortStrategy())
                        .Sort(listToSort);
            Console.WriteLine(sorted.Stringify());

            sorted = sorter
                        .WithSortingStrategy(new NotActuallySortedStrategy())
                        .Sort(listToSort);
            Console.WriteLine(sorted.Stringify());

            Console.ReadLine();
        }
        
    }
}
