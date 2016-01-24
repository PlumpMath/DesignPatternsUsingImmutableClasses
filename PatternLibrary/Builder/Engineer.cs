namespace PatternLibrary.Builder
{
    public class Engineer
    {
        private readonly IRobotBuilder Builder;

        public Engineer() { }
        public Engineer(IRobotBuilder builder)
        {
            Builder = builder;
        }
        public Engineer WithRobotBuilder(IRobotBuilder builder)
        {
            return new Engineer(builder);
        }

        public Robot CreateRobot()
        {
            var head = Builder.CreateRobotHead();
            var left_arm = Builder.CreateRobotArm();
            var right_arm = Builder.CreateRobotArm();
            var platform = Builder.CreateRobotPlatform();
            return 
                new Robot()
                .With(head)
                .With(left_arm)
                .With(right_arm)
                .With(platform);
        }
    }
}
