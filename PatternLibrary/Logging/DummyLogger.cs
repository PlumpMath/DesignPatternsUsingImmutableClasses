using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLibrary.Logging
{
    public class DummyLogger : ILogger
    {
        public void WriteLine(object message)
        {
        }
    }
}
