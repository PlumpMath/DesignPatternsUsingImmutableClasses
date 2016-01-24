using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternLibrary.Memento;

namespace Memento
{
    public class FibSequence : ISaveable
    {
        private class FibSequenceMemento : IMemento
        {
            public readonly int A;
            public readonly int B;
            public FibSequenceMemento(int a, int b)
            {
                A = a;
                B = b;
            }
        }
        public int Value { get { return B; } }
        private readonly int A;
        private readonly int B;

        public FibSequence()
        {
            A = 1;
            B = 1;
        }

        public FibSequence(IMemento memento)
        {
            var mem = (memento as FibSequenceMemento);
            A = mem.A;
            B = mem.B;
        }

        private FibSequence(int a, int b)
        {
            A = a;
            B = b;
        }

        public FibSequence Next()
        {
            return new FibSequence(B, A+B);
        }

        public IMemento GetMemento()
        {
            return new FibSequenceMemento(A, B);
        }

        public T FromMemento<T>(IMemento memento) where T : ISaveable
        {
            return (T)(ISaveable)new FibSequence(memento);
        }
    }
}
