using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public interface IStateMachine
    {
        string DescribeState { get; }
        IStateMachine Perform(string command);
    }
}
