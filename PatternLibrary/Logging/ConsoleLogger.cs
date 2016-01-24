using System;

namespace PatternLibrary.Logging
{
    public class ConsoleLogger : ILogger
    {
        public void WriteLine(object message)
        {
            Console.WriteLine(message);
        }
    }
}
