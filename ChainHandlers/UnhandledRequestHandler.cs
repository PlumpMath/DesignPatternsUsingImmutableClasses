using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainHandlers
{
    public class UnhandledRequestHandler : IHandler
    {
        public bool CanHandle(IRequest request)
        {
            return true;
        }

        public void Handle(IRequest request)
        {
            Console.WriteLine("Request unhandled");
        }
        
    }
}
