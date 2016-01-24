using System;
using PatternLibrary.Logging;

namespace PatternLibrary.Handlers
{
    public class StartWithBigLetterRequestHandler : IHandler
    {
        private readonly ILogger _logger;

        public StartWithBigLetterRequestHandler()
        {
            _logger = new DummyLogger();
        }

        public StartWithBigLetterRequestHandler(ILogger logger)
        {
            _logger = logger;
        }

        public bool CanHandle(IRequest request)
        {
            var data = request?.Data;
            var firstLetter = data?[0];
            if (firstLetter != null)
                return firstLetter.ToString().ToUpper() == firstLetter.ToString();
            return false;
        }

        public void Handle(IRequest request)
        {
            _logger.WriteLine("Request handled in StartWithBigLetterHandler");
        }
    }
}
