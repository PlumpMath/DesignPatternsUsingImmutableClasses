using System;
using System.Linq;
using PatternLibrary.Logging;
using PatternLibrary.Memento;

namespace Memento
{
    class Program
    {
        static void Main()
        {
            ILogger logger = new ConsoleLogger();
            logger.WriteLine("First sequence");
            var seqGen = Enumerable.Range(0, 10).Aggregate(
                new FibSequence(),
                (seqGenerator, iter) => {
                    logger.WriteLine(seqGenerator.Value);
                    return seqGenerator.Next();
                });
            var memento = ((ISaveable)seqGen).GetMemento();
            
            logger.WriteLine("Second sequence[continued]");
            Enumerable.Range(0, 10).Aggregate(
                seqGen,
                (seqGenerator, iter) => {
                    logger.WriteLine(seqGenerator.Value);
                    return seqGenerator.Next();
                });

            logger.WriteLine("Third sequence[from memento - should be like 2nd]");
            Enumerable.Range(0, 10).Aggregate(
                new FibSequence(memento),
                (seqGenerator, iter) => {
                    logger.WriteLine(seqGenerator.Value);
                    return seqGenerator.Next();
                });
            Console.ReadLine();
        }
    }
}
