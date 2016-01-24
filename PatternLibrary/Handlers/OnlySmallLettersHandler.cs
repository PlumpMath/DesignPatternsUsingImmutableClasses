using System;
using System.Linq;

namespace PatternLibrary.Handlers
{
    public class OnlySmallLettersHandler : IHandler
    {
        public bool CanHandle(IRequest request)
        {
            return request?
                     .Data?
                     .ToList()
                     .All(c => c.ToString().ToLower() == c.ToString()) 
                     ?? false;
        }

        public void Handle(IRequest request)
        {
           Console.WriteLine("Request handled in OnlySmallLettersHandler");
        }
    }
}
