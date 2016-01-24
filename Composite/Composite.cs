using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternLibrary.Composite;
using Toolkit;

namespace Composite
{
    public class Composite : IComposite
    {

        private readonly IReadOnlyCollection<IComponent> Children = new List<IComponent>();

        public Composite()
        {
        }

        public Composite(IReadOnlyCollection<IComponent> children)
        {
            Children = new List<IComponent>(children);
        }

        public int GetValue
        {
            get
            {
                return Children.Sum(child => child.GetValue);
            }
        }

        public IComposite AddChild(IComponent component)
        {
            var children = new List<IComponent>(Children.DeepClone());
            children.Add(component);
            return new Composite(children);
        }
    }
}
