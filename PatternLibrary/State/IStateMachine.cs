namespace PatternLibrary.State
{
    public interface IStateMachine
    {
        string DescribeState { get; }
        IStateMachine Perform(string command);
    }
}
