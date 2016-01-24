using System;
using System.Linq;
using PatternLibrary.Logging;

namespace PatternLibrary.Handlers
{
    public class OnlySmallLettersHandler : IHandler
    {
        private readonly ILogger _logger;
        public OnlySmallLettersHandler()
        {
            _logger = new DummyLogger();
        }

        public OnlySmallLettersHandler(ILogger logger)
        {
            _logger = logger;
        }

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
           _logger.WriteLine("Request handled in OnlySmallLettersHandler");
        }
    }
}
