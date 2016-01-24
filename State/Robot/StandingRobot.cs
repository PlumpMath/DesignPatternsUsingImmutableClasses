using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternLibrary.State;

namespace State.Robot
{
    internal class StandingRobot : AbstractRobot
    {
        public override int Speed => 0;

        public override IStateMachine Perform(string command)
        {
            switch (command)
            {
                case "Run":
                    Console.WriteLine("Running!!!");
                    return new RunningRobot();
                case "Walk":
                    Console.WriteLine("Walking...");
                    return new WalkingRobot();
                case "Stand":
                    Console.WriteLine("I am standing, right?");
                    return new StandingRobot();
                case "Crawl":
                    Console.WriteLine("Getting on my kness!");
                    return new CrawlingRobot();
                default:
                    Console.WriteLine("Eeeeem, should I do what?");
                    return new ConfusedRobot();
            }
        }
    }
}
