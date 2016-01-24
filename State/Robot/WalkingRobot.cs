using System;
using PatternLibrary.Logging;
using PatternLibrary.State;

namespace State.Robot
{
    internal class WalkingRobot : AbstractRobot
    {
        public override int Speed => 4;

        public WalkingRobot(ILogger logger = null) : base(logger)
        {
        }

        public override IStateMachine Perform(string command)
        {
            switch (command)
            {
                case "Run":
                    _logger.WriteLine("3, 2, 1 running!");
                    return new RunningRobot(_logger);
                case "Walk":
                    _logger.WriteLine("Already walking...");
                    return new WalkingRobot(_logger);
                case "Stand":
                    _logger.WriteLine("Okey, standing.");
                    return new StandingRobot(_logger);
                case "Crawl":
                    _logger.WriteLine("Oks, on my knees after lil' walk.");
                    return new CrawlingRobot(_logger);
                default:
                    _logger.WriteLine("Eeeeem, should I do what?");
                    return new ConfusedRobot(_logger);
            }
        }
    }
}