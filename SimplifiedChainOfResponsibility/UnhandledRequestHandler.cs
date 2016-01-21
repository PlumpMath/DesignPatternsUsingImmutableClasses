using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplifiedChainOfResponsibility
{
    public class UnhandledRequestHandler : IHandler
    {
        public bool Handle(IRequest request)
        {
            Console.WriteLine($"Request unhandled: {(string.IsNullOrEmpty(request?.Data) ? "EMPTY MSG" : request.Data)}");
            return true;
        }
    }
}
