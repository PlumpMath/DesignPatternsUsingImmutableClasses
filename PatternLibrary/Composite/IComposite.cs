namespace PatternLibrary.Composite
{
    public interface IComposite : IComponent
    {
        IComposite AddChild(IComponent component);
    }
}
