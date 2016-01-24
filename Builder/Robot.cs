using System.Collections.Generic;
using System.Linq;
using Builder.Parts;
using PatternLibrary.Builder;
using Toolkit;

namespace Builder
{
    public class Robot : IProduct
    {
        private readonly IReadOnlyCollection<string> _elements = new List<string>();

        public Robot(){ }
        public Robot(IEnumerable<string> elements)
        {
            _elements = elements.ToList().DeepClone();
        }

        public Robot With(string element)
        {
            var newList = _elements.ToList().DeepClone();
            newList.Add(element);
            return new Robot(newList);
        }

        public IReadOnlyCollection<string> GetRobotElements()
        {
            return _elements.DeepClone();
        }

        public Robot WithHead(RobotHead head)
        {
            return With(head.Prop);
        }

        public Robot WithLeftArm(RobotArm leftArm)
        {
            return With(leftArm.Prop);
        }

        public Robot WithRightArm(RobotArm rightArm)
        {
            return With(rightArm.Prop);
        }

        public Robot WithPlatform(RobotPlatform platform)
        {
            return With(platform.Prop);
        }
    }
}
