using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var cor = new ChainOfResponsibilityFactory()
                        .AddHandler(new OnlySmallLettersHandler())
                        .AddHandler(new StartWithBigLetterRequestHandler())
                        .AddHandler(new UnhandledRequestHandler())
                        .CreateChainOfResponsibility();

            cor.Handle(new Request("all_small_letters_request"));
            cor.Handle(new Request("FirstIsBigRequest"));
            cor.Handle(new Request(null));

            Console.ReadLine();
        }
    }
}
