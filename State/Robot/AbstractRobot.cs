using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Robot
{
    internal abstract class AbstractRobot : IStateMachine
    {
        public virtual string DescribeState
        {
            get {
                return "I'm a " + GetType().Name;
            }
        }
        public abstract IStateMachine Perform(string command);
        public abstract int Speed { get; }
    }
}
