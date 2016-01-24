using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Parts
{
    public class RobotArm
    {
        public readonly string Prop;
        public RobotArm(string prop)
        {
            Prop = prop;
        }
    }
}
