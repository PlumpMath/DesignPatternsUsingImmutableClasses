using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfHandlers
{
    public interface IHandler
    {
        bool Handle(IRequest request);
    }

    public interface IRequest
    {
        string Data { get; }
    }

    public class HandlersEngine
    {
        private readonly IList<IHandler> Handlers = new List<IHandler>();

        public HandlersEngine() {
        }

        private HandlersEngine(IList<IHandler> handlers)
        {
            Handlers = handlers;
        }

        public void Handle(IRequest request)
        {
            Handlers.Any(handler => handler.Handle(request));
        }

        public HandlersEngine AddHandler(IHandler handler)
        {
            var handlers = new List<IHandler>(Handlers);
                handlers.Add(handler);
            return new HandlersEngine(handlers);
        }
    }
}
