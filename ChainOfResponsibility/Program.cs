using System;
using PatternLibrary.ChainOfResponsibility;
using PatternLibrary.Handlers;
using PatternLibrary.Logging;

namespace ChainOfResponsibility
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

            SendRequests(MakeChain(funcBasedLoggingHandler, logger));
            SendRequests(MakeChainUsingFactory(funcBasedLoggingHandler, logger));

            Console.ReadLine();
        }

        private static void SendRequests(IHandler cor)
        {
            cor.Handle(new Request("all_small_letters_request"));
            cor.Handle(new Request("FirstIsBigRequest"));
            cor.Handle(new Request(null));
        }

        private static IHandler MakeChain(IHandler funcLoggingHandler, ILogger logger)
        {
            return new ChainHandler(new OnlySmallLettersHandler(logger))
                                .SetNextHandler(
                                    new ChainHandler(new StartWithBigLetterRequestHandler(logger))
                                        .SetNextHandler(
                                            new ChainHandler(funcLoggingHandler)
                                                .SetNextHandler(
                                                    new ChainHandler(new UnhandledRequestHandler(logger))
                                                )
                                            )
                                        );
        }

        private static IHandler MakeChainUsingFactory(IHandler funcBasedLoggingHandler, ILogger logger)
        {
            return new ChainOfResponsibilityFactory()
                                    .AddHandler(new OnlySmallLettersHandler(logger))
                                    .AddHandler(new StartWithBigLetterRequestHandler(logger))
                                    .AddHandler(funcBasedLoggingHandler)
                                    .AddHandler(new UnhandledRequestHandler(logger))
                                    .CreateChainOfResponsibility();
            
        }
    }
}
