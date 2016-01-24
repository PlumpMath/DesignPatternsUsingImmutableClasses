using System;
using PatternLibrary.Logging;
using PatternLibrary.State;

namespace State.Robot
{
    internal class RunningRobot : AbstractRobot
    {
        public override int Speed => 10;
        public RunningRobot(ILogger logger = null) : base(logger)
        {
        }
        public override IStateMachine Perform(string command)
        {
            switch (command)
            {
                case "Run":
                    _logger.WriteLine("I'm already running, bro!");
                    return new RunningRobot(_logger);
                case "Walk":
                    _logger.WriteLine("Ok, chill, walking now.");
                    return new WalkingRobot(_logger);
                case "Stand":
                    _logger.WriteLine("Chill, standing now.");
                    return new StandingRobot(_logger);
                case "Crawl":
                    _logger.WriteLine("Then run, now crawl, decide dude...");
                    return new CrawlingRobot(_logger);
                default:
                    _logger.WriteLine("Eeeeem, should I do what?");
                    return new ConfusedRobot(_logger);
            }
        }
    }
}