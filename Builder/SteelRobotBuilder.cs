using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
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
