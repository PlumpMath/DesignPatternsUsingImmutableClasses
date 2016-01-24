namespace PatternLibrary.Builder
{
    public class SteelRobotBuilder : IRobotBuilder
    {
        public string CreateRobotArm()
        {
            return "Steel arm";
        }

        public string CreateRobotHead()
        {
            return "Steel head";
        }

        public string CreateRobotPlatform()
        {
            return "Steel platform";
        }
    }
}
