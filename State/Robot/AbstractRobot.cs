using PatternLibrary.State;

namespace State.Robot
{
    internal abstract class AbstractRobot : IStateMachine
    {
        public virtual string DescribeState =>  "I'm a " + GetType().Name;
        public abstract IStateMachine Perform(string command);
        public abstract int Speed { get; }
    }
}
