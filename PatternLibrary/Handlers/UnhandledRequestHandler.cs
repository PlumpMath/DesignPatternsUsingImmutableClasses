using System;

namespace PatternLibrary.Handlers
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
