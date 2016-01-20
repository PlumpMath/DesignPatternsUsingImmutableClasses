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

    public interface IChainHandler
    {
        void Handle(IRequest request);
    }

    public class ChainHandler : IChainHandler
    {
        private readonly IHandler Handler;
        private readonly IChainHandler NextHandler;
        public ChainHandler(IHandler handler, IChainHandler nextHandler)
        {
            Handler = handler;
            NextHandler = nextHandler;
        }

        public void Handle(IRequest request)
        {
            if (!Handler.Handle(request))
            {
                NextHandler.Handle(request);
            }
        }
    }

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

    public class ChainOfResponsibilityFactory
    {
        private readonly IList<IHandler> Handlers = new List<IHandler>();
        public ChainOfResponsibilityFactory()
        {
        }

        public ChainOfResponsibilityFactory(IList<IHandler> handlers)
        {
            Handlers = handlers;
        }

        public ChainOfResponsibilityFactory AddHandler(IHandler handler)
        {
            var handlers = Handlers.ToList();
            handlers.Add(handler);
            return new ChainOfResponsibilityFactory(handlers);
        }

        public IChainHandler CreateChainOfResponsibility()
        {
            return Handlers.Reverse().Aggregate(
                new List<IChainHandler>(),
                (chain, handler) => {
                    IChainHandler last = null;
                    if (chain.Count > 0)
                    {
                        last = chain.Last();
                    }
                    chain.Add(new ChainHandler(handler, last));
                    return chain;
                    }
                ).Last();
        }
    }
}
