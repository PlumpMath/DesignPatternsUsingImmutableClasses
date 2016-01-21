using ChainHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ChainHandler
    {
        private readonly IHandler Handler;
        private readonly ChainHandler NextHandler;

        public ChainHandler(IHandler handler)
        {
            Handler = handler;
        }

        public ChainHandler(IHandler handler, ChainHandler nextHandler)
        {
            Handler = handler;
            NextHandler = nextHandler;
        }

        public void Handle(IRequest request)
        {
            if (Handler.CanHandle(request))
            {
                Handler.Handle(request);
            }
            else NextHandler.Handle(request);
        }

        public ChainHandler SetNextHandler(ChainHandler nextHandler)
        {
            return new ChainHandler(Handler, nextHandler);
        }
    }
}
