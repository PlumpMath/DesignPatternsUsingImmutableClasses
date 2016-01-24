using PatternLibrary.Logging;
using PatternLibrary.State;

namespace State.Robot
{
    internal abstract class AbstractRobot : IStateMachine
    {
        protected readonly ILogger _logger;

        protected AbstractRobot(ILogger logger = null)
        {
            _logger = logger ?? new DummyLogger();
        }
        public virtual string DescribeState =>  "I'm a " + GetType().Name;
        public abstract IStateMachine Perform(string command);
        public abstract int Speed { get; }
    }
}
