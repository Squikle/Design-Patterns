using System;
using System.Collections.Generic;

namespace Observer
{
    class Program
    {
        static void Main()
        {
            ObservableList<int> list = new ObservableList<int>();
            Printer printer = new Printer();
            list.AddObserver(printer);
            list.AddObserver(new ReversePrinter());
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }
            list.RemoveObserver(printer);
            for (int i = 0; i < 5; i++)
            {
                list.Remove(i);
            }

            Console.ReadKey();
        }

        interface IObservable
        {
            void AddObserver(IObserver observer);
            void RemoveObserver(IObserver observer);
            void NotifyObservers(string notification);
        }

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
        interface IObserver
        {
            void Update(string notification);
        }

        class Printer : IObserver
        {
            public void Update(string notification)
            {
                Console.WriteLine(notification);
            }
        }

        class ReversePrinter : IObserver
        {
            public void Update(string notification)
            {
                char[] charArray = notification.ToCharArray();
                Array.Reverse(charArray);
                Console.WriteLine(charArray);
            }
        }
    }
}
