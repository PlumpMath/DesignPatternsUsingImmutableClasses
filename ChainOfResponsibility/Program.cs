using System;
using PatternLibrary.ChainOfResponsibility;
using PatternLibrary.Handlers;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcBasedLoggingHandler = new FuncbasedHandler(
                (request) => false,
                (request) =>
                {
                    Console.WriteLine($"Logging handler-> {(string.IsNullOrEmpty(request?.Data) ? "EMPTY MSG" : request.Data)}");
                });

            SendRequests(MakeChain(funcBasedLoggingHandler));
            SendRequests(MakeChainUsingFactory(funcBasedLoggingHandler));

            Console.ReadLine();
        }

        private static void SendRequests(IHandler cor)
        {
            cor.Handle(new Request("all_small_letters_request"));
            cor.Handle(new Request("FirstIsBigRequest"));
            cor.Handle(new Request(null));
        }

        private static IHandler MakeChain(FuncbasedHandler funcBasedLoggingHandler)
        {
            return new ChainHandler(new OnlySmallLettersHandler())
                                .SetNextHandler(
                                    new ChainHandler(new StartWithBigLetterRequestHandler())
                                        .SetNextHandler(
                                            new ChainHandler(funcBasedLoggingHandler)
                                                .SetNextHandler(
                                                    new ChainHandler(new UnhandledRequestHandler())
                                                )
                                            )
                                        );
        }

        private static IHandler MakeChainUsingFactory(FuncbasedHandler funcBasedLoggingHandler)
        {
            return new ChainOfResponsibilityFactory()
                                    .AddHandler(new OnlySmallLettersHandler())
                                    .AddHandler(new StartWithBigLetterRequestHandler())
                                    .AddHandler(funcBasedLoggingHandler)
                                    .AddHandler(new UnhandledRequestHandler())
                                    .CreateChainOfResponsibility();
            
        }
    }
}
