using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainHandlers
{
    public class StartWithBigLetterRequestHandler : IHandler
    {
        public bool CanHandle(IRequest request)
        {
            return request != null
                   &&
                   !string.IsNullOrEmpty(request.Data)
                   &&
                   request.Data[0].ToString().ToUpper() == request.Data[0].ToString();
        }

        public void Handle(IRequest request)
        {
            Console.WriteLine("Request handled in StartWithBigLetterHandler");
        }
    }
}
