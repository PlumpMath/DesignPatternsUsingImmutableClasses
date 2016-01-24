using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternLibrary.Logging;
using PatternLibrary.State;

namespace State.Robot
{
    internal class StandingRobot : AbstractRobot
    {
        public override int Speed => 0;

        public StandingRobot(ILogger logger = null) : base(logger)
        {
        }

        public override IStateMachine Perform(string command)
        {
            switch (command)
            {
                case "Run":
                    _logger.WriteLine("Running!!!");
                    return new RunningRobot(_logger);
                case "Walk":
                    _logger.WriteLine("Walking...");
                    return new WalkingRobot(_logger);
                case "Stand":
                    _logger.WriteLine("I am standing, right?");
                    return new StandingRobot(_logger);
                case "Crawl":
                    _logger.WriteLine("Getting on my kness!");
                    return new CrawlingRobot(_logger);
                default:
                    _logger.WriteLine("Eeeeem, should I do what?");
                    return new ConfusedRobot(_logger);
            }
        }
    }
}
