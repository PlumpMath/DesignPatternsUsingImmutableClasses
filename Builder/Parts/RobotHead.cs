using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Parts
{
    public class RobotHead
    {
        public readonly string Prop;
        public RobotHead(string prop)
        {
            Prop = prop;
        }
    }
}
