using System;

namespace PatternLibrary.Handlers
{
    public class FuncbasedHandler : IHandler
    {
        private readonly Action<IRequest> _handler;
        private readonly Func<IRequest, bool> _canHandle;
        public FuncbasedHandler(Func<IRequest, bool> canHandleFunc, Action<IRequest> handlerFunc)
        {
            _handler = handlerFunc;
            _canHandle = canHandleFunc;
        }

        public bool CanHandle(IRequest request)
        {
            return _canHandle(request);
        }

        public void Handle(IRequest request)
        {
            _handler(request);
        }

        void IHandler.Handle(IRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
