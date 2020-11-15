using System.Collections.Generic;
using Observer.Interfaces;

namespace Observer.Classes
{
    class ObservableList<T> : IObservable
    {
        private readonly List<T> _list;
        private readonly List<IObserver> _observers;

        public ObservableList()
        {
            _list = new List<T>();
            _observers = new List<IObserver>();
        }

        public void Add(T element)
        {
            _list.Add(element);
            NotifyObservers($"Object {element} added");
        }
        public void Remove(T element)
        {
            _list.Remove(element);
            NotifyObservers($"Object {element} removed");
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(string notification)
        {
            foreach (var observer in _observers)
            {
                observer.Update(notification);
            }
        }

    }
}
