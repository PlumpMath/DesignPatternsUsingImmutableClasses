using Builder.Parts;
using PatternLibrary.Builder;

namespace Builder
{
    public class RobotEngineer : IEngineer
    {
        private readonly IBuilder _builder;

        public RobotEngineer() { }
        public RobotEngineer(IBuilder builder)
        {
            _builder = builder;
        }
        public IProduct CreateProduct()
        {
            var head = _builder.Create<RobotHead>();
            var leftArm = _builder.Create<RobotArm>();
            var rightArm = _builder.Create<RobotArm>();
            var platform = _builder.Create<RobotPlatform>();
            return
                new Robot()
                .WithHead(head)
                .WithLeftArm(leftArm)
                .WithRightArm(rightArm)
                .WithPlatform(platform);
        }

        public IEngineer WithBuilder(IBuilder builder)
        {
            return new RobotEngineer(builder);
        }
    }
}
