﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplifiedChainOfResponsibility
{
    public class ChainOfResponsibility
    {
        IList<IHandler> Handlers = new List<IHandler>();

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
            Handlers.Any(handler => handler.Handle(request));
        }

    }
}
