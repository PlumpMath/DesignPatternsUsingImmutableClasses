﻿using ChainHandlers;
using System;

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

        private static void SendRequests(ChainHandler cor)
        {
            cor.Handle(new Request("all_small_letters_request"));
            cor.Handle(new Request("FirstIsBigRequest"));
            cor.Handle(new Request(null));
        }

        private static ChainHandler MakeChain(FuncbasedHandler funcBasedLoggingHandler)
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

        private static ChainHandler MakeChainUsingFactory(FuncbasedHandler funcBasedLoggingHandler)
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
