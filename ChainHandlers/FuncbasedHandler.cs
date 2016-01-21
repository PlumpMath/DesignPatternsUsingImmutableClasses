using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainHandlers
{
    public class FuncbasedHandler : IHandler
    {
        private readonly Action<IRequest> handler;
        private readonly Func<IRequest, bool> canHandle;
        public FuncbasedHandler(Func<IRequest, bool> canHandleFunc, Action<IRequest> handlerFunc)
        {
            handler = handlerFunc;
            canHandle = canHandleFunc;
        }

        public bool CanHandle(IRequest request)
        {
            return canHandle(request);
        }

        public void Handle(IRequest request)
        {
            handler(request);
        }

        void IHandler.Handle(IRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
