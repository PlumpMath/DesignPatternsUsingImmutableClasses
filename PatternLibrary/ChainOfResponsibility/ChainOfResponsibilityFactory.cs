using PatternLibrary.Handlers;
using System.Collections.Generic;
using System.Linq;

namespace PatternLibrary.ChainOfResponsibility
{
    public class ChainOfResponsibilityFactory
    {
        private readonly IReadOnlyCollection<IHandler> _handlers = new List<IHandler>();

        public ChainOfResponsibilityFactory(){}
        public ChainOfResponsibilityFactory(IEnumerable<IHandler> handlers)
        {
            _handlers = new List<IHandler>(handlers);
        }

        public ChainOfResponsibilityFactory AddHandler(IHandler handler)
        {
            var handlers = _handlers.ToList();
            handlers.Add(handler);
            return new ChainOfResponsibilityFactory(handlers);
        }

        public IHandler CreateChainOfResponsibility()
        {
            return _handlers.Reverse().Aggregate(
                new List<ChainHandler>(),
                (chain, handler) => {
                    ChainHandler last = null;
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
