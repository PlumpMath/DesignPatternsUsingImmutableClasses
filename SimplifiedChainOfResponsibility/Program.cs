using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplifiedChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcBasedLoggingHandler = new FuncbasedHandler((request) =>
            {
                Console.WriteLine($"Logging handler-> {(string.IsNullOrEmpty(request?.Data) ? "EMPTY MSG" : request.Data)}");
                return false;
            });
            var cor = new ChainOfResponsibility()
                            .AddHandler(new OnlySmallLettersHandler())
                            .AddHandler(new StartWithBigLetterRequestHandler())
                            .AddHandler(funcBasedLoggingHandler)
                            .AddHandler(new UnhandledRequestHandler());

            cor.Handle(new Request("all_small_letters_request"));
            cor.Handle(new Request("FirstIsBigRequest"));
            cor.Handle(new Request(null));

            Console.ReadLine();
        }
    }
}
