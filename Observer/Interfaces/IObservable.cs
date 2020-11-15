namespace Observer.Interfaces
{
    interface IObservable
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers(string notification);
    }
}
