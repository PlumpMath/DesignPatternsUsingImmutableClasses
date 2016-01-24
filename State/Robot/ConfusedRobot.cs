using System;
using PatternLibrary.Logging;
using PatternLibrary.State;

namespace State.Robot
{
    internal class ConfusedRobot : AbstractRobot
    {
        public override int Speed => -123;
        public ConfusedRobot(ILogger logger = null) : base(logger)
        {
        }
        public override IStateMachine Perform(string command)
        {
            _logger.WriteLine("Buelbellelbeble");
            return new ConfusedRobot(_logger);
        }
    }
}
