using System;
using PatternLibrary.Logging;
using PatternLibrary.State;

namespace State.Robot
{
    internal class CrawlingRobot : AbstractRobot
    {
        public override int Speed => 2;
        public CrawlingRobot(ILogger logger = null) : base(logger)
        {
        }
        public override IStateMachine Perform(string command)
        {
            switch (command)
            {
                case "Run":
                    _logger.WriteLine("Stand up, run!!!");
                    return new RunningRobot(_logger);
                case "Walk":
                    _logger.WriteLine("Stand up, walk...");
                    return new WalkingRobot(_logger);
                case "Stand":
                    _logger.WriteLine("Stand up.");
                    return new StandingRobot(_logger);
                case "Crawl":
                    _logger.WriteLine("Doing nothing actually.");
                    return new CrawlingRobot(_logger);
                default:
                    _logger.WriteLine("Eeeeem, should I do what?");
                    return new ConfusedRobot(_logger);
            }
        }
    }
}