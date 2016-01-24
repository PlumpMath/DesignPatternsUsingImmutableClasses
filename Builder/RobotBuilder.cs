using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Parts;
using PatternLibrary.Builder;

namespace Builder
{
    public class RobotBuilder : IBuilder
    {

        public T Create<T>()
        {
            var robotHead = typeof (RobotHead).FullName;
            var robotArm = typeof(RobotArm).FullName;
            var robotPlatform = typeof(RobotPlatform).FullName;

            var type = typeof(T).FullName;
            if(robotHead == type)
                return (T)(object)new RobotHead("Steel head");
            if (robotArm == type)
                return (T)(object)new RobotArm("Steel arm");
            if (robotPlatform == type)
                return (T)(object)new RobotPlatform("Steel platform");

            return default(T);
        }
    }
}
