using System.Collections.Generic;
using System.Linq;
using PatternLibrary.Handlers;

namespace PatternLibrary.ChainOfResponsibility
{
    public class ChainOfResponsibility
    {
        IReadOnlyCollection<IHandler> Handlers = new List<IHandler>();

        public ChainOfResponsibility() { }
        public ChainOfResponsibility(IReadOnlyCollection<IHandler> handlers)
        {
            Handlers = new List<IHandler>(handlers);
        }

        public ChainOfResponsibility AddHandler(IHandler handler)
        {
            var newHandlers = new List<IHandler>(Handlers);
            newHandlers.Add(handler);
            return new ChainOfResponsibility(newHandlers);
        }

        public void Handle(IRequest request)
        {
            Handlers.Any(handler => {
                if (handler.CanHandle(request))
                {
                    handler.Handle(request);
                    return true;
                }
                else
                {
                    return false;
                }
                });
        }

    }
}
