using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Robot
{
    internal class ConfusedRobot : AbstractRobot
    {
        public override int Speed
        {
            get
            {
                return -123;
            }
        }

        public override IStateMachine Perform(string command)
        {
            Console.WriteLine("Buelbellelbeble");
            return new ConfusedRobot();
        }
    }
}
