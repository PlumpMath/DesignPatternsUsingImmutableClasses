using PatternLibrary.Composite;

namespace Composite
{
    public class IntNode : INode
    {
        private readonly int _value;
        public int GetValue => _value;

        public IntNode(int val)
        {
            _value = val;
        }
    }
}
