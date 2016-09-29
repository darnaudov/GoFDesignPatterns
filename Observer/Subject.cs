using System;
using System.Collections.Generic;

namespace Observer
{
    class Subject
    {
        private string _state;
        private List<IObserver> observers;

        public Subject()
        {
            observers = new List<IObserver>();
        }

        public string State
        {
            get
            {
                return _state;
            }

            set
            {
                _state = value;
                Console.WriteLine("State changed to: " + value);
                NotifyObservers();
            }
        }

        public void RegisterObserver(IObserver obs)
        {
            Console.WriteLine("Register observer");
            observers.Add(obs);
        }

        public void UnregisterObserver(IObserver obs)
        {
            Console.WriteLine("Unregister observer");
            observers.Remove(obs);
        }
        
        public void NotifyObservers()
        {
            Console.WriteLine("Notifying observers...");

            foreach (IObserver obs in observers)
            {
                obs.Update(this);
            }
        }
    }
}
