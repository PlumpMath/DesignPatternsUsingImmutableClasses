using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfHandlers
{
    public class OnlySmallLettersHandler : IHandler
    {
        private bool CanHandle(IRequest request)
        {
            return request != null
                   &&
                   !string.IsNullOrEmpty(request.Data)
                   &&
                   request
                    .Data
                    .ToList()
                    .All(c => c.ToString().ToLower() == c.ToString());
        }

        public bool Handle(IRequest request)
        {
            if (!CanHandle(request)) return false;

            Console.WriteLine("Request handled in OnlySmallLettersHandler");
            return true;
        }
    }
}
