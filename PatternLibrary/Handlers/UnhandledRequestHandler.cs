using System;
using PatternLibrary.Logging;

namespace PatternLibrary.Handlers
{
    public class UnhandledRequestHandler : IHandler
    {
        private readonly ILogger _logger;
        public UnhandledRequestHandler()
        {
            _logger = new DummyLogger();
        }

        public UnhandledRequestHandler(ILogger logger)
        {
            _logger = logger;
        }

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
