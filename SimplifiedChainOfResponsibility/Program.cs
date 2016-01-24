using System;
using PatternLibrary.ChainOfResponsibility;
using PatternLibrary.Handlers;
using PatternLibrary.Logging;

namespace SimplifiedChainOfResponsibility
{
    internal class Program
    {
        static void Main()
        {
            ILogger logger = new ConsoleLogger();
            var funcBasedLoggingHandler = new FuncbasedHandler(
                request => false,
                request =>
                {
                    logger.WriteLine($"Logging handler-> {(string.IsNullOrEmpty(request?.Data) ? "EMPTY MSG" : request.Data)}");
                });

            var cor = new ChainOfResponsibility()
                            .AddHandler(new OnlySmallLettersHandler(logger))
                            .AddHandler(new StartWithBigLetterRequestHandler(logger))
                            .AddHandler(funcBasedLoggingHandler)
                            .AddHandler(new UnhandledRequestHandler(logger));

            cor.Handle(new Request("all_small_letters_request"));
            cor.Handle(new Request("FirstIsBigRequest"));
            cor.Handle(new Request(null));

            Console.ReadLine();
        }
    }
}
