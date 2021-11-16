namespace StOPatterns
{
    public interface ISubject
    {
        
        void AddObserver(IObserver o);
        void NotifyObservers();
        void RemoveObserver(IObserver o );
    }
}