using System;
using PatternLibrary.State;

namespace State.Robot
{
    internal class RunningRobot : AbstractRobot
    {
        public override int Speed => 10;
        
        public override IStateMachine Perform(string command)
        {
            switch (command)
            {
                case "Run":
                    Console.WriteLine("I'm already running, bro!");
                    return new RunningRobot();
                case "Walk":
                    Console.WriteLine("Ok, chill, walking now.");
                    return new WalkingRobot();
                case "Stand":
                    Console.WriteLine("Chill, standing now.");
                    return new StandingRobot();
                case "Crawl":
                    Console.WriteLine("Then run, now crawl, decide dude...");
                    return new CrawlingRobot();
                default:
                    Console.WriteLine("Eeeeem, should I do what?");
                    return new ConfusedRobot();
            }
        }
    }
}