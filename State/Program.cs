using State.Robot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
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
