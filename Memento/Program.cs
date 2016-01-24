using System;
using System.Linq;
using PatternLibrary.Memento;

namespace Memento
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("First sequence");
            var seqGen = Enumerable.Range(0, 10).Aggregate(
                new FibSequence(),
                (seqGenerator, iter) => {
                    Console.WriteLine(seqGenerator.Value);
                    return seqGenerator.Next();
                });
            var memento = ((ISaveable)seqGen).GetMemento();
            
            Console.WriteLine("Second sequence[continued]");
            Enumerable.Range(0, 10).Aggregate(
                seqGen,
                (seqGenerator, iter) => {
                    Console.WriteLine(seqGenerator.Value);
                    return seqGenerator.Next();
                });

            Console.WriteLine("Third sequence[from memento - should be like 2nd]");
            Enumerable.Range(0, 10).Aggregate(
                new FibSequence(memento),
                (seqGenerator, iter) => {
                    Console.WriteLine(seqGenerator.Value);
                    return seqGenerator.Next();
                });
            Console.ReadLine();
        }
    }
}
