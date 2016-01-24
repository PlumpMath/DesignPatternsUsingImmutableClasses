using System;
using System.Collections.Generic;
using Builder.Parts;
using PatternLibrary.Builder;

namespace Builder
{
    public class Robot : IProduct
    {
        IReadOnlyCollection<string> Elements = new List<string>();

        public Robot(){ }
        public Robot(IReadOnlyCollection<string> elements)
        {
            Elements = new List<string>(elements);
        }

        public Robot With(string element)
        {
            var newList = new List<string>(Elements);
            newList.Add(element);
            return new Robot(newList);
        }

        public IReadOnlyList<string> GetRobotElements()
        {
            return new List<string>(Elements);
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
