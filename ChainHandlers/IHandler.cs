using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainHandlers
{
    public interface IHandler
    {
        bool CanHandle(IRequest request);
        void Handle(IRequest request);
    }
}
