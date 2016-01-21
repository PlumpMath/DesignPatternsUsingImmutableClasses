using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainHandlers
{
    public class OnlySmallLettersHandler : IHandler
    {
        public bool CanHandle(IRequest request)
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

        public void Handle(IRequest request)
        {
           Console.WriteLine("Request handled in OnlySmallLettersHandler");
        }
    }
}
