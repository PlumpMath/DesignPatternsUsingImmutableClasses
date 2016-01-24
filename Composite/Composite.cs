using System.Collections.Generic;
using System.Linq;
using PatternLibrary.Composite;
using Toolkit;

namespace Composite
{
    public class Composite : IComposite
    {

        private readonly IReadOnlyCollection<IComponent> _children 
            = new List<IComponent>();

        public Composite()
        {
        }

        public Composite(IEnumerable<IComponent> children)
        {
            _children = new List<IComponent>(children);
        }

        public int GetValue
        {
            get
            {
                return _children.Sum(child => child.GetValue);
            }
        }

        public IComposite AddChild(IComponent component)
        {
            var children = _children.ToList().DeepClone();
            children.Add(component);
            return new Composite(children);
        }
    }
}
