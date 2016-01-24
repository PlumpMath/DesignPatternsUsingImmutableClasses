namespace PatternLibrary.Memento
{
    public interface ISaveable
    {
        IMemento GetMemento();
        T FromMemento<T>(IMemento memento) 
            where T : ISaveable;
    }
}