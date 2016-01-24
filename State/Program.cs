using State.Robot;
using System;
using PatternLibrary.Logging;

namespace State
{
   internal class Program
    {
        static void Main()
        {
            ILogger logger = new ConsoleLogger();
            var robot = new StandingRobot(logger);

            robot
                .Perform("Walk")
                .Perform("Stand")
                .Perform("Crawl")
                .Perform("Run")
                .Perform("Stand")
                .Perform("Walk")
                .Perform("Run")
                .Perform("Crawl")
                .Perform("Netflix&Chill");

            Console.ReadLine();
        }
    }
}
