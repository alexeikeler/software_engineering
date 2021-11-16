namespace StOPatterns
{
    public interface IObserver
    {
        void Update(Point currentPosition, bool isMasked);
    }
}