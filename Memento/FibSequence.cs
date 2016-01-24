using System;
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

        public int Value => _b;
        private readonly int _a;
        private readonly int _b;

        public FibSequence()
        {
            _a = 1;
            _b = 1;
        }

        public FibSequence(IMemento memento)
        {
            if (memento == null)
                throw new ArgumentNullException("Memento is null");
            var mem = (memento as FibSequenceMemento);
            if(mem == null)
                throw new ArgumentException($"Memento's type mismatch: {memento.GetType().Name}");
            _a = mem.A;
            _b = mem.B;
        }

        private FibSequence(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public FibSequence Next()
        {
            return new FibSequence(_b, _a+_b);
        }

        public IMemento GetMemento()
        {
            return new FibSequenceMemento(_a, _b);
        }

        public T FromMemento<T>(IMemento memento) where T : ISaveable
        {
            return (T)(ISaveable)new FibSequence(memento);
        }
    }
}
