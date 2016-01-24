namespace PatternLibrary.Handlers
{
    public interface IHandler
    {
        bool CanHandle(IRequest request);
        void Handle(IRequest request);
    }
}
