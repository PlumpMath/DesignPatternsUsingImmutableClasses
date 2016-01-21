using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfHandlers
{
    public class UnhandledRequestHandler : IHandler
    {
        public bool Handle(IRequest request)
        {
            Console.WriteLine("Request unhandled");
            return true;
        }
    }
}
