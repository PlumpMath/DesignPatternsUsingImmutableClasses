using System;

namespace State.Robot
{
    internal class WalkingRobot : AbstractRobot
    {
        public override int Speed
        {
            get
            {
                return 4;
            }
        }

        public override IStateMachine Perform(string command)
        {
            switch (command)
            {
                case "Run":
                    Console.WriteLine("3, 2, 1 running!");
                    return new RunningRobot();
                case "Walk":
                    Console.WriteLine("Already walking...");
                    return new WalkingRobot();
                case "Stand":
                    Console.WriteLine("Okey, standing.");
                    return new StandingRobot();
                case "Crawl":
                    Console.WriteLine("Oks, on my knees after lil' walk.");
                    return new CrawlingRobot();
                default:
                    Console.WriteLine("Eeeeem, should I do what?");
                    return new ConfusedRobot();
            }
        }
    }
}