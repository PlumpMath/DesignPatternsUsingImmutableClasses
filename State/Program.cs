using State.Robot;
using System;

namespace State
{
   internal class Program
    {
        static void Main()
        {
            var robot = new StandingRobot();

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
