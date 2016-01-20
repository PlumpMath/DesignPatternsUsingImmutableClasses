using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public interface IHandler
    {
        bool Handle(IRequest request);
    }

    public interface IRequest
    {
        string Data { get; }
    }

    public class ChainOfHandlers
    {
        private readonly IList<IHandler> Handlers = new List<IHandler>();

        public ChainOfHandlers() {
        }

        private ChainOfHandlers(IList<IHandler> handlers)
        {
            Handlers = handlers;
        }

        public void Handle(IRequest request)
        {
            Handlers.Any(handler => handler.Handle(request));
        }

        public ChainOfHandlers AddHandler(IHandler handler)
        {
            var handlers = new List<IHandler>(Handlers);
                handlers.Add(handler);
            return new ChainOfHandlers(handlers);
        }
    }
}
