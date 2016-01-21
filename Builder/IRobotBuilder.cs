namespace Builder
{
    public interface IRobotBuilder
    {
        string CreateRobotHead();
        string CreateRobotArm();
        string CreateRobotPlatform();
    }
}