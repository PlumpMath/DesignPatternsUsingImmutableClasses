using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var cor = new ChainOfHandlers()
                            .AddHandler(new OnlySmallLettersHandler())
                            .AddHandler(new StartWithBigLetterRequestHandler())
                            .AddHandler(new UnhandledRequestHandler());

            cor.Handle(new Request("all_small_letters_request"));
            cor.Handle(new Request("FirstIsBigRequest"));
            cor.Handle(new Request(null));

            Console.ReadLine();
        }
    }
}
