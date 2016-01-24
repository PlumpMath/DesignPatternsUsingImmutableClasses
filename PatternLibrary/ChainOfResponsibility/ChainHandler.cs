using PatternLibrary.Handlers;

namespace PatternLibrary.ChainOfResponsibility
{
    public class ChainHandler : IHandler
    {
        private readonly IHandler _handler;
        private readonly ChainHandler _nextHandler;

        public ChainHandler(IHandler handler)
        {
            _handler = handler;
        }

        public ChainHandler(IHandler handler, ChainHandler nextHandler)
        {
            _handler = handler;
            _nextHandler = nextHandler;
        }

        public bool CanHandle(IRequest request)
        {
            var canHandle = _handler.CanHandle(request);
            return canHandle || 
                (_nextHandler?.CanHandle(request) ?? false);
                                
        }

        public void Handle(IRequest request)
        {
            if (_handler.CanHandle(request))
            {
                _handler.Handle(request);
            }
            else _nextHandler.Handle(request);
        }

        public ChainHandler SetNextHandler(ChainHandler nextHandler)
        {
            return new ChainHandler(_handler, nextHandler);
        }
    }
}
