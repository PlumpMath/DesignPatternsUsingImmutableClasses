using System.Collections.Generic;
using System.Linq;
using PatternLibrary.Handlers;
using Toolkit;

namespace PatternLibrary.ChainOfResponsibility
{
    public class ChainOfResponsibility
    {
        private readonly IReadOnlyCollection<IHandler> _handlers = new List<IHandler>();

        public ChainOfResponsibility() { }
        public ChainOfResponsibility(IEnumerable<IHandler> handlers)
        {
            _handlers = new List<IHandler>(handlers);
        }

        public ChainOfResponsibility AddHandler(IHandler handler)
        {
            var newHandlers = _handlers.ToList().DeepClone();
            newHandlers.Add(handler);
            return new ChainOfResponsibility(newHandlers);
        }

        public void Handle(IRequest request)
        {
            var firstHandler = _handlers
                .FirstOrDefault(handler => handler.CanHandle(request));
            firstHandler?.Handle(request);
        }

    }
}
