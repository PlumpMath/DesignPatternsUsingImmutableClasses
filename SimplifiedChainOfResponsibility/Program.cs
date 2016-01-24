using System;
using PatternLibrary.ChainOfResponsibility;
using PatternLibrary.Handlers;

namespace SimplifiedChainOfResponsibility
{
    internal class Program
    {
        static void Main()
        {
            var funcBasedLoggingHandler = new FuncbasedHandler(
                request => false,
                request =>
                {
                    Console.WriteLine($"Logging handler-> {(string.IsNullOrEmpty(request?.Data) ? "EMPTY MSG" : request.Data)}");
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
