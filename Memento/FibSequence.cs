using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class FibSequence
    {
        private class FibSequenceMemento : IFibSequenceMemento
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

        public FibSequence(IFibSequenceMemento memento)
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

        public IFibSequenceMemento GetMemento()
        {
            return new FibSequenceMemento(A, B);
        }
    }
}
