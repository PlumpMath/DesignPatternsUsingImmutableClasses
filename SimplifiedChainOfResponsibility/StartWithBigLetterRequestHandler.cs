using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplifiedChainOfResponsibility
{
    public class StartWithBigLetterRequestHandler : IHandler
    {
        private bool CanHandle(IRequest request)
        {
            return request != null
                   &&
                   !string.IsNullOrEmpty(request.Data)
                   &&
                   request.Data[0].ToString().ToUpper() == request.Data[0].ToString();
        }

        public bool Handle(IRequest request)
        {
            if (!CanHandle(request)) return false;

            Console.WriteLine($"Request handled in StartWithBigLetterHandler: {request.Data}");
            return true;
        }
    }
}
