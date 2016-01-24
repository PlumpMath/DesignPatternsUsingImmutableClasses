using System;

namespace PatternLibrary.Handlers
{
    public class StartWithBigLetterRequestHandler : IHandler
    {
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
            Console.WriteLine("Request handled in StartWithBigLetterHandler");
        }
    }
}
