namespace PatternLibrary.Builder
{
    public interface IBuilder
    {
        T Create<T>();
    }
}