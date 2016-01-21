using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolkit;

namespace Composite
{
    public class Composite : IComposite
    {

        private readonly IList<IComponent> Children = new List<IComponent>();

        public Composite()
        {
        }

        public Composite(IList<IComponent> children)
        {
            Children = children;
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
            var children = Children.DeepClone();
            children.Add(component);
            return new Composite(children);
        }
    }
}
