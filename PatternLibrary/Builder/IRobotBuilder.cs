namespace PatternLibrary.Builder
{
    public interface IRobotBuilder
    {
        string CreateRobotHead();
        string CreateRobotArm();
        string CreateRobotPlatform();
    }
}