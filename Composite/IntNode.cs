using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class IntNode : INode
    {
        private readonly int value;
        public int GetValue
        {
            get
            {
                return value;
            }
        }

        public IntNode(int val)
        {
            value = val;
        }
    }
}
