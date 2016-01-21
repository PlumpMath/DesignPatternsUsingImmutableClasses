using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainHandlers
{
    public class Request : IRequest
    {
        private readonly string data;

        public Request(string data)
        {
            this.data = data;
        }

        public string Data
        {
            get
            {
                return data;
            }
        }
    }
}
