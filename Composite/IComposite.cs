using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public interface IComposite : IComponent
    {
        IComposite AddChild(IComponent component);
    }
}
