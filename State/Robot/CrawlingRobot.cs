using System;

namespace State.Robot
{
    internal class CrawlingRobot : AbstractRobot
    {
        public override int Speed
        {
            get
            {
                return 2;
            }
        }

        public override IStateMachine Perform(string command)
        {
            switch (command)
            {
                case "Run":
                    Console.WriteLine("Stand up, run!!!");
                    return new RunningRobot();
                case "Walk":
                    Console.WriteLine("Stand up, walk...");
                    return new WalkingRobot();
                case "Stand":
                    Console.WriteLine("Stand up.");
                    return new StandingRobot();
                case "Crawl":
                    Console.WriteLine("Doing nothing actually.");
                    return new CrawlingRobot();
                default:
                    Console.WriteLine("Eeeeem, should I do what?");
                    return new ConfusedRobot();
            }
        }
    }
}